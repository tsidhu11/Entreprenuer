using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrepreneur_App
{
    public class Opportunity : IEquatable<Opportunity>
    {
        private string fullName, invention, industryName, location, story, playerExplanation;
        private ValuePropositions valueProp;
        private EDdistribution edDistrib;
        private int cashInvestor, cashPlayer;
        private bool accept;
        

        public Opportunity(string inName, string inInvention, string inIndustryName, string inLocation, ValuePropositions vp, EDdistribution inDistrib)
        {
            this.fullName = inName;
            this.invention = inInvention;
            this.industryName = inIndustryName;
            this.location = inLocation;
            this.valueProp = vp;
            this.edDistrib = inDistrib;
            this.cashInvestor = cashInvesterCalculation();
            this.cashPlayer = cashPlayerCalculation();
            setStory();
        }

        public string getNAICSNumber()
        {
            return this.industryName.Split(',')[0];
        }
        public string getSplitIndustryName()
        {
            return this.industryName.Split(',')[1];
        }


        public void setLocation(string inLoc)
        {
            this.location = inLoc;
        }

        public string getLocation()
        {
            return this.location;
        }

        public void setPlayerExplanation(string inExplain)
        {
            this.playerExplanation = inExplain;
        }
        public string getPlayerExplanation()
        {
            return this.playerExplanation;
        }

        public void setAcceptBool(bool inBool)
        {
            this.accept = inBool;
        }
        public bool getAcceptBool()
        {
            return this.accept;
        }

        public void setStory()
        {
            Random propMathRand = new Random();
            double valuePropMath = propMathRand.Next(20, 60) / valueProp.getValuePropMath();

            this.story = "An opportunity to form an equally-owned join venture with " + fullName + " to produce his " + invention + " that he invented " +
                "while at the " + location +". This B2B product " + valueProp.getExplanation() + Math.Round(valuePropMath,1) + "% in the " + getSplitIndustryName() + "(NAICS " + getNAICSNumber()+ ") industry. The " +
                invention + " is expected to sell " + string.Format("{0:n0}", edDistrib.getExpected()) + " units in its first five years on the market; however this could be as low as " +
                string.Format("{0:n0}", edDistrib.getPessimistic()) + " units and as high as " + string.Format("{0:n0}", edDistrib.getOptimistic()) + " units. " + fullName + " can potentionally provide $" +
                string.Format("{0:n0}", cashInvestor) + " to this joint venture and he expects the entrepreneur (player) to provide $" + string.Format("{0:n0}", cashPlayer) + ".";
        }
        public string getStory()
        {
            return this.story;
        }

        private int cashInvesterCalculation()
        {
            Random rand1 = new Random();
            double var1 = rand1.NextDouble();
            
            Random rand2 = new Random();
            double var2 = rand2.NextDouble();
            
            while(var1 == var2)
            {
                var2 = rand2.NextDouble();
            }

            //calculations
            int cash = Convert.ToInt32(500000 + 100000 * (Math.Sqrt(-2 * Math.Log(var1)) * (Math.Cos(2 * Math.PI * var2))));
            
            //rounding to nearest thousand
            int result = cash % 1000 >= 500 ? cash + 1000 - cash % 1000 : cash - cash % 1000;
            return result;
        }
        private int cashPlayerCalculation()
        {
            Random rand1 = new Random();
            double var1 = rand1.NextDouble();

            Random rand2 = new Random();
            double var2 = rand2.NextDouble();

            while (var1 == var2)
            {
                var2 = rand2.NextDouble();
            }
            //calculations
            int cash = Convert.ToInt32(1000000 + 200000 * (Math.Sqrt(-2 * Math.Log(var1)) * (Math.Cos(2 * Math.PI * var2))));

            //rounding to nearest thousand
            int result = cash % 1000 >= 500 ? cash + 1000 - cash % 1000 : cash - cash % 1000;
            return result;
        }

        public void setFullName(string inName)
        {
            this.fullName = inName;
        }
        public string getFullName()
        {
            return this.fullName;
        }

        public void setInvention(string inInvention)
        {
            this.invention = inInvention;
        }
        public string getInvention()
        {
            return this.invention;
        }

        public void setIndustryName(string inIndustry)
        {
            this.industryName = inIndustry;
        }
        public string getIndustryName()
        {
            return this.industryName;
        }

        public void setValueProposition(ValuePropositions inVP)
        {
            this.valueProp = inVP;
        }
        public ValuePropositions getValuePropositions()
        {
            return this.valueProp;
        }

        public void setEDdistribution(EDdistribution inED)
        {
            this.edDistrib = inED;
        }
        public EDdistribution getEDdistribution()
        {
            return this.edDistrib;
        }
        
        public void setCashInvestor(int inCash)
        {
            this.cashInvestor = inCash;
        }
        public int getCashInvestor()
        {
            return this.cashInvestor;
        }

        public void setCashPlayer(int inCash)
        {
            this.cashPlayer = inCash;
        }
        public int getCashPlayer()
        {
            return this.cashPlayer;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Opportunity);
        }

        public bool Equals(Opportunity other)
        {
            return other != null &&
                   fullName == other.fullName &&
                   invention == other.invention &&
                   industryName == other.industryName &&
                   EqualityComparer<ValuePropositions>.Default.Equals(valueProp, other.valueProp) &&
                   EqualityComparer<EDdistribution>.Default.Equals(edDistrib, other.edDistrib) &&
                   cashInvestor == other.cashInvestor &&
                   cashPlayer == other.cashPlayer;
        }

        public override int GetHashCode()
        {
            var hashCode = -1004443935;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(fullName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(invention);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(industryName);
            hashCode = hashCode * -1521134295 + EqualityComparer<ValuePropositions>.Default.GetHashCode(valueProp);
            hashCode = hashCode * -1521134295 + EqualityComparer<EDdistribution>.Default.GetHashCode(edDistrib);
            hashCode = hashCode * -1521134295 + cashInvestor.GetHashCode();
            hashCode = hashCode * -1521134295 + cashPlayer.GetHashCode();
            return hashCode;
        }
    }
}
