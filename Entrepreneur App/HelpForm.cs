using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrepreneur_App
{
    public partial class HelpForm : Form
    {
        Opportunity curOpp;
        public HelpForm()
        {
            InitializeComponent();
        }
        public HelpForm(Opportunity inCurOpp)
        {
            InitializeComponent();
            curOpp = inCurOpp;
        }

        private void materialBtn_Click(object sender, EventArgs e)
        {
            curOpp.getEDdistribution().setMaterialsBool(true);
            string variable = materialBtn.Text;
            int index = this.helpDGV.Rows.Add();
            this.helpDGV.Rows[index].Cells[0].Value = variable;
            this.helpDGV.Rows[index].Cells[1].Value = "$" + curOpp.getEDdistribution().materialCostExpected.ToString();
            this.helpDGV.Rows[index].Cells[2].Value = "$" + curOpp.getEDdistribution().materialCostPessimistic.ToString();
            this.helpDGV.Rows[index].Cells[3].Value = "$" + curOpp.getEDdistribution().materialCostOptimistic.ToString();
            materialBtn.Enabled = false;
        }

        private void laborCostBtn_Click(object sender, EventArgs e)
        {
            curOpp.getEDdistribution().setLaborBool(true);
            string variable = laborCostBtn.Text;
            int index = this.helpDGV.Rows.Add();
            this.helpDGV.Rows[index].Cells[0].Value = variable;
            this.helpDGV.Rows[index].Cells[1].Value = "$" + curOpp.getEDdistribution().laborCostsExpected.ToString();
            this.helpDGV.Rows[index].Cells[2].Value = "$" + curOpp.getEDdistribution().laborCostsPessimistic.ToString();
            this.helpDGV.Rows[index].Cells[3].Value = "$" + curOpp.getEDdistribution().laborCostsOptimistic.ToString();
            laborCostBtn.Enabled = false;

            /*helpTextLabel.Text = "Expected labor costs: " + curOpp.getEDdistribution().laborCostsExpected.ToString() + "\n";
            helpTextLabel.Text += "Pessimistic labor costs: " + curOpp.getEDdistribution().laborCostsPessimistic.ToString() + "\n";
            helpTextLabel.Text += "Optimistic labor costs: " + curOpp.getEDdistribution().laborCostsOptimistic.ToString() + "\n";*/
        }

        private void priceBtn_Click(object sender, EventArgs e)
        {

            curOpp.getEDdistribution().setPriceBool(true);
            string variable = priceBtn.Text;
            int index = this.helpDGV.Rows.Add();
            this.helpDGV.Rows[index].Cells[0].Value = variable;
            this.helpDGV.Rows[index].Cells[1].Value = "$" + curOpp.getEDdistribution().priceExpected.ToString();
            this.helpDGV.Rows[index].Cells[2].Value = "$" + curOpp.getEDdistribution().pricePessimistic.ToString();
            this.helpDGV.Rows[index].Cells[3].Value = "$" + curOpp.getEDdistribution().priceOptimistic.ToString();
            priceBtn.Enabled = false;

            /*helpTextLabel.Text = "Expected price: " + curOpp.getEDdistribution().priceExpected.ToString() + "\n";
            helpTextLabel.Text += "Pessimistic price: " + curOpp.getEDdistribution().pricePessimistic.ToString() + "\n";
            helpTextLabel.Text += "Optimistic price: " + curOpp.getEDdistribution().priceOptimistic.ToString() + "\n";*/
        }

        private void developmentTimeBtn_Click(object sender, EventArgs e)
        {
            curOpp.getEDdistribution().setDevTimeBool(true);
            string variable = developmentTimeBtn.Text;
            int index = this.helpDGV.Rows.Add();
            this.helpDGV.Rows[index].Cells[0].Value = variable;
            this.helpDGV.Rows[index].Cells[1].Value = curOpp.getEDdistribution().developmentTimeExpected.ToString() + " hrs.";
            this.helpDGV.Rows[index].Cells[2].Value = curOpp.getEDdistribution().developmentTimePessimistic.ToString() + " hrs.";
            this.helpDGV.Rows[index].Cells[3].Value = curOpp.getEDdistribution().developmentTimeOptimistic.ToString() + " hrs.";
            developmentTimeBtn.Enabled = false;


            /*helpTextLabel.Text = "Expected development time: " + curOpp.getEDdistribution().developmentTimeExpected.ToString() + "\n";
            helpTextLabel.Text += "Pessimistic development time: " + curOpp.getEDdistribution().developmentTimePessimistic.ToString() + "\n";
            helpTextLabel.Text += "Optimistic development time: " + curOpp.getEDdistribution().developmentTimeOptimistic.ToString() + "\n";*/
        }

        private void slowGrowthBtn_Click(object sender, EventArgs e)
        {
            curOpp.getEDdistribution().setSlowGrowthBool(true);
            string variable = slowGrowthBtn.Text;
            int index = this.helpDGV.Rows.Add();
            this.helpDGV.Rows[index].Cells[0].Value = variable;
            this.helpDGV.Rows[index].Cells[1].Value = "$" + curOpp.getEDdistribution().slowGrowthExpected.ToString("#,##0");
            this.helpDGV.Rows[index].Cells[2].Value = "$" + curOpp.getEDdistribution().slowGrowthPessimistic.ToString("#,##0");
            this.helpDGV.Rows[index].Cells[3].Value = "$" + curOpp.getEDdistribution().slowGrowthOptimistic.ToString("#,##0");
            slowGrowthBtn.Enabled = false;


            /*helpTextLabel.Text = "Expected investment for slow initial growth: " + curOpp.getEDdistribution().slowGrowthExpected.ToString() + "\n";
            helpTextLabel.Text += "Pessimistic investment for slow initial growth: " + curOpp.getEDdistribution().slowGrowthPessimistic.ToString() + "\n";
            helpTextLabel.Text += "Optimistic investment for slow initial growth: " + curOpp.getEDdistribution().slowGrowthOptimistic.ToString() + "\n";*/
        }

        private void intermediateGrowthBtn_Click(object sender, EventArgs e)
        {
            curOpp.getEDdistribution().setIntGrowthBool(true);
            string variable = intermediateGrowthBtn.Text;
            int index = this.helpDGV.Rows.Add();
            this.helpDGV.Rows[index].Cells[0].Value = variable;
            this.helpDGV.Rows[index].Cells[1].Value = "$" + curOpp.getEDdistribution().intermediateGrowthExpected.ToString("#,##0");
            this.helpDGV.Rows[index].Cells[2].Value = "$" + curOpp.getEDdistribution().intermediateGrowthPessimistic.ToString("#,##0");
            this.helpDGV.Rows[index].Cells[3].Value = "$" + curOpp.getEDdistribution().intermediateGrowthOptimistic.ToString("#,##0");
            intermediateGrowthBtn.Enabled = false;



            /*helpTextLabel.Text = "Expected investment for intermediate initial growth: " + curOpp.getEDdistribution().intermediateGrowthExpected.ToString() + "\n";
            helpTextLabel.Text += "Pessimistic investment for intermediate initial growth: " + curOpp.getEDdistribution().intermediateGrowthPessimistic.ToString() + "\n";
            helpTextLabel.Text += "Optimistic investment for intermediate initial growth: " + curOpp.getEDdistribution().intermediateGrowthOptimistic.ToString() + "\n";*/
        }

        private void rapidGrowthBtn_Click(object sender, EventArgs e)
        {
            curOpp.getEDdistribution().setRapidGrowthBool(true);
            string variable = rapidGrowthBtn.Text;
            int index = this.helpDGV.Rows.Add();
            this.helpDGV.Rows[index].Cells[0].Value = variable;
            this.helpDGV.Rows[index].Cells[1].Value = "$" + curOpp.getEDdistribution().rapidGrowthExpected.ToString("#,##0");
            this.helpDGV.Rows[index].Cells[2].Value = "$" + curOpp.getEDdistribution().rapidGrowthPessimistic.ToString("#,##0");
            this.helpDGV.Rows[index].Cells[3].Value = "$" + curOpp.getEDdistribution().rapidGrowthOptimistic.ToString("#,##0");
            rapidGrowthBtn.Enabled = false;


            /*helpTextLabel.Text = "Expected investment for rapid initial growth: " + curOpp.getEDdistribution().rapidGrowthExpected.ToString() + "\n";
            helpTextLabel.Text += "Pessimistic investment for rapid initial growth: " + curOpp.getEDdistribution().rapidGrowthPessimistic.ToString() + "\n";
            helpTextLabel.Text += "Optimistic investment for rapid initial growth: " + curOpp.getEDdistribution().rapidGrowthOptimistic.ToString() + "\n";*/
        }

        private void curveLaborBtn_Click(object sender, EventArgs e)
        {
            curOpp.getEDdistribution().setCurveLaborBool(true);
            string variable = curveLaborBtn.Text;
            int index = this.helpDGV.Rows.Add();
            this.helpDGV.Rows[index].Cells[0].Value = variable;
            this.helpDGV.Rows[index].Cells[1].Value = curOpp.getEDdistribution().curveLaborExpected.ToString();
            this.helpDGV.Rows[index].Cells[2].Value = curOpp.getEDdistribution().curveLaborPessimistic.ToString();
            this.helpDGV.Rows[index].Cells[3].Value = curOpp.getEDdistribution().curveLaborOptimistic.ToString();
            curveLaborBtn.Enabled = false;
        }

        private void curveMaterialBtn_Click(object sender, EventArgs e)
        {
            curOpp.getEDdistribution().setCurveMaterialBool(true);
            string variable = curveMaterialBtn.Text;
            int index = this.helpDGV.Rows.Add();
            this.helpDGV.Rows[index].Cells[0].Value = variable;
            this.helpDGV.Rows[index].Cells[1].Value = curOpp.getEDdistribution().curveMaterialExpected.ToString();
            this.helpDGV.Rows[index].Cells[2].Value = curOpp.getEDdistribution().curveMaterialPessimistic.ToString();
            this.helpDGV.Rows[index].Cells[3].Value = curOpp.getEDdistribution().curveMaterialOptimistic.ToString();
            curveMaterialBtn.Enabled = false;
        }
    }
}
