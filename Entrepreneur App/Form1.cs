using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace Entrepreneur_App
{
    public partial class MainWindow : Form
    {
        List<string> pastNames = new List<string>();
        List<string> pastInventions = new List<string>();
        List<string> pastIndustryNames = new List<string>();
        List<string>[] pastOppShowing = new List<string>[3];

        Opportunity currentOpportunity;

        List<ValuePropositions> valuePropositionsList;
        ValuePropositions VP;
        EDdistribution ED;
        List<EDdistribution> edDistributionList;
        List<Opportunity> pastOpportunitiesList = new List<Opportunity>();
        private DataBaseConnection DBConnect;

        public MainWindow()
        {
            InitializeComponent();

            DBConnect = new DataBaseConnection();
            pastNames.Clear();
            pastInventions.Clear();
            pastIndustryNames.Clear();
        }
        
        private Opportunity getOpportunity()
        {
            string fullName = DBConnect.fullNameGenerator();
            string invention = DBConnect.inventionGenerator();
            string industryName = DBConnect.industryNameGenerator();
            //valuePropositionsList = DBConnect.valuePropositionGenerator();
            //edDistributionList = DBConnect.edDistributionGenerator();

            VP = DBConnect.valuePropositionsGenerator();
            ED = DBConnect.edDistributionGenerator();


            Random propRand = new Random();
            //ValuePropositions vp = valuePropositionsList[propRand.Next(0, valuePropositionsList.Count)];
            ValuePropositions vp = DBConnect.valuePropositionsGenerator();

            Random edDistRand = new Random();
            //EDdistribution edDist = edDistributionList[edDistRand.Next(0, edDistributionList.Count)];

            EDdistribution edDist = DBConnect.edDistributionGenerator();

            string location = DBConnect.locationGenerator();

            Opportunity opp = new Opportunity(fullName, invention, industryName, location, vp, edDist);

            return opp;
        }

        private void oppButton_Click(object sender, EventArgs e)
        {  
            Opportunity opp1 = getOpportunity();
            
            currentOpportunityLabel.Visible = true;
            opportunityDisplay.Visible = true;
            //pastOpportunityLabel.Visible = true;
            //pastOpportunityDisplay.Visible = true;
            while(pastOpportunitiesList.Contains(opp1))
            {
                opp1 = getOpportunity();
            }
            pastOpportunitiesList.Add(opp1);
            currentOpportunity = opp1;
            opportunityDisplay.Text = opp1.getStory();
            
            helpBtn.Enabled = true;
            helpBtn.Visible = true;
            describeBtn.Enabled = true;
            describeBtn.Visible = true;
            oppButton.Enabled = false;
            oppButton.Visible = false;
            explanationTextBox.Visible = false;
            acceptOppButton.Visible = false;
            rejectOppButton.Visible = false;
        }
       
        private void explanationTextBox_TextChanged(object sender, EventArgs e)
        {
            int charLeft = 280 - explanationTextBox.Text.Length;
            this.maxCharacterLabel.Text = "Characters left: " + charLeft + ". (Max 280).";
        }

        private void acceptOppButton_Click(object sender, EventArgs e)
        {
            if(explanationTextBox.Text.Length > 0)
            {
                currentOpportunity.setAcceptBool(true);
                currentOpportunity.setPlayerExplanation(explanationTextBox.Text);
                explanationTextBox.Clear();
                pastOpportunityDisplay.Text = pastOpportunitiesList[pastOpportunitiesList.Count-1].getStory();
                explainLabel.Text = "Compare this opportunity to the past opportunity:";
                MessageBox.Show("Good Job! Onto Phase 2!", "Next Step!");
            }
            else
            {
                MessageBox.Show("Please give an explanation before deciding.", "Explanation not given.");
            }
        }

        private void rejectOppButton_Click(object sender, EventArgs e)
        {
            if (explanationTextBox.Text.Length > 0)
            {
                pastDGV.Rows.Clear();
                currentOpportunity.setAcceptBool(false);
                currentOpportunity.setPlayerExplanation(explanationTextBox.Text);
                pastOpportunityDisplay.Text = pastOpportunitiesList[pastOpportunitiesList.Count-1].getStory();
                pastOpportunityDisplay.Text += " \n Player Explanation: " + pastOpportunitiesList[pastOpportunitiesList.Count - 1].getPlayerExplanation();
                EDdistribution curED = currentOpportunity.getEDdistribution();
                
                if (curED.getMaterialsBool())
                {
                    int index = this.pastDGV.Rows.Add();
                    this.pastDGV.Rows[index].Cells[0].Value = curED.getMaterialsVariable();
                    this.pastDGV.Rows[index].Cells[1].Value = "$" + curED.materialCostExpected.ToString("#,##0");
                    this.pastDGV.Rows[index].Cells[2].Value = "$" + curED.materialCostPessimistic.ToString("#,##0");
                    this.pastDGV.Rows[index].Cells[3].Value = "$" + curED.materialCostOptimistic.ToString("#,##0");
                }
                if (curED.getLaborBool())
                {
                    int index = this.pastDGV.Rows.Add();
                    this.pastDGV.Rows[index].Cells[0].Value = curED.getLaborCostsVariable();
                    this.pastDGV.Rows[index].Cells[1].Value = "$" + curED.laborCostsExpected.ToString("#,##0");
                    this.pastDGV.Rows[index].Cells[2].Value = "$" + curED.laborCostsPessimistic.ToString("#,##0");
                    this.pastDGV.Rows[index].Cells[3].Value = "$" + curED.laborCostsOptimistic.ToString("#,##0");
                }
                if (curED.getPriceBool())
                {
                    int index = this.pastDGV.Rows.Add();
                    this.pastDGV.Rows[index].Cells[0].Value = curED.getPriceVariable();
                    this.pastDGV.Rows[index].Cells[1].Value = "$" + curED.priceExpected.ToString("#,##0");
                    this.pastDGV.Rows[index].Cells[2].Value = "$" + curED.pricePessimistic.ToString("#,##0");
                    this.pastDGV.Rows[index].Cells[3].Value = "$" + curED.priceOptimistic.ToString("#,##0");
                }
                if (curED.getDevTimeBool())
                {
                    int index = this.pastDGV.Rows.Add();
                    this.pastDGV.Rows[index].Cells[0].Value = curED.getDevTimeVariable();
                    this.pastDGV.Rows[index].Cells[1].Value = curED.developmentTimeExpected.ToString() + " hrs.";
                    this.pastDGV.Rows[index].Cells[2].Value = curED.developmentTimePessimistic.ToString() + " hrs.";
                    this.pastDGV.Rows[index].Cells[3].Value = curED.developmentTimeOptimistic.ToString() + " hrs.";
                }
                if (curED.getSlowGrowthBool())
                {
                    int index = this.pastDGV.Rows.Add();
                    this.pastDGV.Rows[index].Cells[0].Value = curED.getSlowGrowthVariable();
                    this.pastDGV.Rows[index].Cells[1].Value = "$" + curED.slowGrowthExpected.ToString("#,##0");
                    this.pastDGV.Rows[index].Cells[2].Value = "$" + curED.slowGrowthPessimistic.ToString("#,##0");
                    this.pastDGV.Rows[index].Cells[3].Value = "$" + curED.slowGrowthOptimistic.ToString("#,##0");
                }
                if (curED.getIntGrowthBool())
                {
                    int index = this.pastDGV.Rows.Add();
                    this.pastDGV.Rows[index].Cells[0].Value = curED.getIntGrowthVariable();
                    this.pastDGV.Rows[index].Cells[1].Value = "$" + curED.intermediateGrowthExpected.ToString("#,##0");
                    this.pastDGV.Rows[index].Cells[2].Value = "$" + curED.intermediateGrowthPessimistic.ToString("#,##0");
                    this.pastDGV.Rows[index].Cells[3].Value = "$" + curED.intermediateGrowthOptimistic.ToString("#,##0");
                }
                if (curED.getRapidGrowthBool())
                {
                    int index = this.pastDGV.Rows.Add();
                    this.pastDGV.Rows[index].Cells[0].Value = curED.getRapidGrowthVariable();
                    this.pastDGV.Rows[index].Cells[1].Value = "$" + curED.rapidGrowthExpected.ToString("#,##0");
                    this.pastDGV.Rows[index].Cells[2].Value = "$" + curED.rapidGrowthPessimistic.ToString("#,##0");
                    this.pastDGV.Rows[index].Cells[3].Value = "$" + curED.rapidGrowthOptimistic.ToString("#,##0");
                }
                if (curED.getCurveLaborBool())
                {
                    int index = this.pastDGV.Rows.Add();
                    this.pastDGV.Rows[index].Cells[0].Value = curED.getCurveLaborVariable();
                    this.pastDGV.Rows[index].Cells[1].Value = curED.curveLaborExpected.ToString();
                    this.pastDGV.Rows[index].Cells[2].Value = curED.curveLaborPessimistic.ToString();
                    this.pastDGV.Rows[index].Cells[3].Value = curED.curveLaborOptimistic.ToString();
                }
                if (curED.getCurveMaterialBool())
                {
                    int index = this.pastDGV.Rows.Add();
                    this.pastDGV.Rows[index].Cells[0].Value = curED.getCurveMaterialsVariable();
                    this.pastDGV.Rows[index].Cells[1].Value = curED.curveMaterialExpected.ToString();
                    this.pastDGV.Rows[index].Cells[2].Value = curED.curveMaterialPessimistic.ToString();
                    this.pastDGV.Rows[index].Cells[3].Value = curED.curveMaterialOptimistic.ToString();
                }
                
                explanationTextBox.Clear();
                explainLabel.Text = "Compare this opportunity to the past opportunity:";
                oppButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please give an explanation before deciding.", "Explanation not given.");
            }
        }

        public void helpBtn_Click(object sender, EventArgs e)
        {
            Form helpForm = new HelpForm(currentOpportunity);
            helpForm.Show();
        }  

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            string messageBoxText = "Are you sure you want to exit?";
            string caption = "Exit Entrepreneur";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            
            DialogResult result =  MessageBox.Show(messageBoxText, caption, button, icon);

            switch(result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("YES CLICKED");
                    if(pastOpportunitiesList.Count > 1)
                        DBConnect.writeOpportunitiesToDatabase(int.Parse(IDTextBox.Text), pastOpportunitiesList);
                    break;
                case DialogResult.No:
                    MessageBox.Show("NO CLICKED");
                    e.Cancel = (result == DialogResult.No);
                    break;
            }
        }
        

        private void playButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.Length > 0 &&
                lastNameTextBox.Text.Length > 0 &&
                IDTextBox.Text.Length > 0 &&
                classCodeBox.Text.Length > 0 &&
                classNumberTextBox.Text.Length > 0)
            {
                //hiding all the player info screen
                firstNameLabel.Visible = false;
                firstNameTextBox.Visible = false;
                lastNameLabel.Visible = false;
                lastNameTextBox.Visible = false;
                IDLabel.Visible = false;
                IDTextBox.Visible = false;
                classCodeLabel.Visible = false;
                classCodeBox.Visible = false;
                classNumberLabel.Visible = false;
                classNumberTextBox.Visible = false;
                playButton.Visible = false;
                instrucLabel.Visible = false;
                instructionLabel.Visible = false;
                oppButton_Click(sender, e);
                string fullName = firstNameTextBox.Text + " " + lastNameTextBox.Text;
                string className = classCodeBox.Text + " " + classNumberTextBox.Text;
                int id = int.Parse(IDTextBox.Text);
                DBConnect.writeNamesToDatabase(fullName, className, id);
            }
            else
            {
                MessageBox.Show("NOT ENOUGH");
            }
        }

        private void IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void describeBtn_Click(object sender, EventArgs e)
        {
            acceptOppButton.Visible = true;
            rejectOppButton.Visible = true;
            acceptOppButton.Enabled = true;
            rejectOppButton.Enabled = true;
            explanationTextBox.Visible = true;
            helpBtn.Visible = false;
            describeBtn.Visible = false;
        }
    }
}
