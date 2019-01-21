using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrepreneur_App
{
    public class EDdistribution : IEquatable<EDdistribution>
    {
        private string variable;
        private int expectedLowerLimit, expectedUpperLimit, pessimisticLowerLimit, pessimisticUpperLimit;
        private int optimisticLowerLimit, optimisticUpperLimit, expected, pessimistic, optimistic;
        private int[] materialCosts = { 75, 125, 25, 50, 200, 500 };
        private int[] laborCosts = { 75, 125, 25, 50, 200, 500 };
        private int[] price = { 250, 300, 150, 175, 400, 600 };
        private int[] developmentTime = { 2500, 3500, 1500, 2000, 4000, 7000 };
        private int[] slowGrowth = { 700000, 800000, 500000, 600000, 900000, 1000000 };
        private int[] intermediateGrowth = { 1400000, 1600000, 1200000, 1300000, 1700000, 1800000 };
        private int[] rapidGrowth = { 2900000, 3100000, 2500000, 2700000, 3300000, 3500000 };
        private double[] curveLabor = { 0.05, 0.06, 0.02, 0.04, 0.07, 0.10 };
        private double[] curveMaterial = { 0.03, 0.04, 0.01, 0.02, 0.05, 0.07 };
        public int materialCostExpected, materialCostPessimistic, materialCostOptimistic;
        public int laborCostsExpected, laborCostsPessimistic, laborCostsOptimistic;
        public int priceExpected, pricePessimistic, priceOptimistic;
        public int developmentTimeExpected, developmentTimePessimistic, developmentTimeOptimistic;
        public int slowGrowthExpected, slowGrowthPessimistic, slowGrowthOptimistic;
        public int intermediateGrowthExpected, intermediateGrowthPessimistic, intermediateGrowthOptimistic;
        public int rapidGrowthExpected, rapidGrowthPessimistic, rapidGrowthOptimistic;
        public double curveLaborExpected, curveLaborPessimistic, curveLaborOptimistic;
        public double curveMaterialExpected, curveMaterialPessimistic, curveMaterialOptimistic;
        private Boolean materialsBool, laborBool, priceBool, devTimeBool, slowGrowthBool, intGrowthBool, rapidGrowthBool, curveLaborBool, curveMaterialsBool;

        public EDdistribution(string inVar, int inExpectedLowerLimit, int inExpectedUpperLimit, int inPessimisticLowerLimit,
            int inPessimisticUpperLimit, int inOptimisticLowerLimit, int inOptimisticUpperLimit)
        {
            this.variable = inVar;
            this.expectedLowerLimit = inExpectedLowerLimit;
            this.expectedUpperLimit = inExpectedUpperLimit;
            this.pessimisticLowerLimit = inPessimisticLowerLimit;
            this.pessimisticUpperLimit = inPessimisticUpperLimit;
            this.optimisticLowerLimit = inOptimisticLowerLimit;
            this.optimisticUpperLimit = inOptimisticUpperLimit;

            Random expectedRand = new Random();
            this.expected = (expectedRand.Next(expectedLowerLimit, expectedUpperLimit) + 50) / 1000 * 1000;
            this.pessimistic = expectedRand.Next(pessimisticLowerLimit, pessimisticUpperLimit);
            this.optimistic = expectedRand.Next(optimisticLowerLimit, optimisticUpperLimit);

            this.materialCostExpected = expectedRand.Next(materialCosts[0], materialCosts[1]);
            this.materialCostPessimistic = expectedRand.Next(materialCosts[2], materialCosts[3]);
            this.materialCostOptimistic = expectedRand.Next(materialCosts[4], materialCosts[5]);

            this.laborCostsExpected = expectedRand.Next(laborCosts[0], laborCosts[1]);
            this.laborCostsPessimistic = expectedRand.Next(laborCosts[2], laborCosts[3]);
            this.laborCostsOptimistic = expectedRand.Next(laborCosts[4], laborCosts[5]);

            this.priceExpected = expectedRand.Next(price[0], price[1]);
            this.pricePessimistic = expectedRand.Next(price[2], price[3]);
            this.priceOptimistic = expectedRand.Next(price[4], price[5]);

            this.developmentTimeExpected = expectedRand.Next(developmentTime[0], developmentTime[1]);
            this.developmentTimePessimistic = expectedRand.Next(developmentTime[4], developmentTime[5]);
            this.developmentTimeOptimistic = expectedRand.Next(developmentTime[2], developmentTime[3]);

            this.slowGrowthExpected = expectedRand.Next(slowGrowth[0], slowGrowth[1]);
            this.slowGrowthPessimistic = expectedRand.Next(slowGrowth[4], slowGrowth[5]);
            this.slowGrowthOptimistic = expectedRand.Next(slowGrowth[2], slowGrowth[3]);

            this.intermediateGrowthExpected = expectedRand.Next(intermediateGrowth[0], intermediateGrowth[1]);
            this.intermediateGrowthPessimistic = expectedRand.Next(intermediateGrowth[4], intermediateGrowth[5]);
            this.intermediateGrowthOptimistic = expectedRand.Next(intermediateGrowth[2], intermediateGrowth[3]);

            this.rapidGrowthExpected = expectedRand.Next(rapidGrowth[0], rapidGrowth[1]);
            this.rapidGrowthPessimistic = expectedRand.Next(rapidGrowth[4], rapidGrowth[5]);
            this.rapidGrowthOptimistic = expectedRand.Next(rapidGrowth[2], rapidGrowth[3]);
        }

        public void setRandoms()
        {
            Random expectedRand = new Random();

            this.materialCostExpected = expectedRand.Next(materialCosts[0], materialCosts[1]);
            this.materialCostPessimistic = expectedRand.Next(materialCosts[4], materialCosts[5]);
            this.materialCostOptimistic = expectedRand.Next(materialCosts[2], materialCosts[3]);

            this.laborCostsExpected = expectedRand.Next(laborCosts[0], laborCosts[1]);
            this.laborCostsPessimistic = expectedRand.Next(laborCosts[4], laborCosts[5]);
            this.laborCostsOptimistic = expectedRand.Next(laborCosts[2], laborCosts[3]);

            this.priceExpected = expectedRand.Next(price[0], price[1]);
            this.pricePessimistic = expectedRand.Next(price[2], price[3]);
            this.priceOptimistic = expectedRand.Next(price[4], price[5]);

            this.developmentTimeExpected = expectedRand.Next(developmentTime[0], developmentTime[1]);
            this.developmentTimePessimistic = expectedRand.Next(developmentTime[4], developmentTime[5]);
            this.developmentTimeOptimistic = expectedRand.Next(developmentTime[2], developmentTime[3]);

            this.slowGrowthExpected = expectedRand.Next(slowGrowth[0], slowGrowth[1]);
            this.slowGrowthPessimistic = expectedRand.Next(slowGrowth[4], slowGrowth[5]);
            this.slowGrowthOptimistic = expectedRand.Next(slowGrowth[2], slowGrowth[3]);

            this.intermediateGrowthExpected = expectedRand.Next(intermediateGrowth[0], intermediateGrowth[1]);
            this.intermediateGrowthPessimistic = expectedRand.Next(intermediateGrowth[4], intermediateGrowth[5]);
            this.intermediateGrowthOptimistic = expectedRand.Next(intermediateGrowth[2], intermediateGrowth[3]);

            this.rapidGrowthExpected = expectedRand.Next(rapidGrowth[0], rapidGrowth[1]);
            this.rapidGrowthPessimistic = expectedRand.Next(rapidGrowth[4], rapidGrowth[5]);
            this.rapidGrowthOptimistic = expectedRand.Next(rapidGrowth[2], rapidGrowth[3]);

            Random random = new Random();
            this.curveLaborExpected = Math.Round((random.NextDouble() * (curveLabor[1] - curveLabor[0]) + curveLabor[0]), 3);
            this.curveLaborPessimistic = Math.Round((random.NextDouble() * (curveLabor[5] - curveLabor[4]) + curveLabor[4]), 3);
            this.curveLaborOptimistic = Math.Round((random.NextDouble() * (curveLabor[3] - curveLabor[2]) + curveLabor[2]), 3);

            this.curveMaterialExpected = Math.Round((random.NextDouble() * (curveMaterial[1] - curveMaterial[0]) + curveMaterial[0]), 3);
            this.curveMaterialPessimistic = Math.Round((random.NextDouble() * (curveMaterial[5] - curveMaterial[4]) + curveMaterial[4]), 3);
            this.curveMaterialOptimistic = Math.Round((random.NextDouble() * (curveMaterial[3] - curveMaterial[2]) + curveMaterial[2]), 3);
        }

        public string getMaterialsVariable()
        {
            return "Expected Material Costs";
        }
        public string getLaborCostsVariable()
        {
            return "Expected unit direct labor costs";
        }
        public string getPriceVariable()
        {
            return "Expected Price";
        }
        public string getDevTimeVariable()
        {
            return "Expected product development time";
        }
        public string getSlowGrowthVariable()
        {
            return "Estimated plant and equipment investment for slow initial growth";
        }
        public string getIntGrowthVariable()
        {
            return "Estimated plant and equipment investment for intermediate initial growth";
        }
        public string getRapidGrowthVariable()
        {
            return "Estimated plant and equipment investment for rapid initial growth";
        }
        public string getCurveLaborVariable()
        {
            return "Expected learning curve coefficient for labor costs";
        }
        public string getCurveMaterialsVariable()
        {
            return "Expected learning curve coefficient for material costs";
        }

        public Boolean getMaterialsBool()
        {
            return materialsBool;
        }
        public void setMaterialsBool(Boolean inBool)
        {
            this.materialsBool = inBool;
        }

        public Boolean getLaborBool()
        {
            return this.laborBool;
        }
        public void setLaborBool(Boolean inBool)
        {
            this.laborBool = inBool;
        }

        public Boolean getPriceBool()
        {
            return this.priceBool;
        }
        public void setPriceBool(Boolean inBool)
        {
            this.priceBool = inBool;
        }

        public Boolean getDevTimeBool()
        {
            return this.devTimeBool;
        }
        public void setDevTimeBool(Boolean inBool)
        {
            this.devTimeBool = inBool;
        }

        public Boolean getSlowGrowthBool()
        {
            return this.slowGrowthBool;
        }
        public void setSlowGrowthBool(Boolean inBool)
        {
            this.slowGrowthBool = inBool;
        }

        public Boolean getIntGrowthBool()
        {
            return this.intGrowthBool;
        }
        public void setIntGrowthBool(Boolean inBool)
        {
            this.intGrowthBool = inBool;
        }

        public Boolean getRapidGrowthBool()
        {
            return this.rapidGrowthBool;
        }
        public void setRapidGrowthBool(Boolean inBool)
        {
            this.rapidGrowthBool = inBool;
        }

        public Boolean getCurveLaborBool()
        {
            return this.curveLaborBool;
        }

        public void setCurveLaborBool(Boolean inBool)
        {
            this.curveLaborBool = inBool;
        }

        public Boolean getCurveMaterialBool()
        {
            return this.curveMaterialsBool;
        }

        public void setCurveMaterialBool(Boolean inBool)
        {
            this.curveMaterialsBool = inBool;
        }

        public EDdistribution(string inVar, int inExpected, int inPessimistic, int inOptimistic)
        {
            this.variable = inVar;
            this.expected = (inExpected + 50) / 1000 * 1000;
            this.pessimistic = (inPessimistic + 50) / 1000 * 1000;
            this.optimistic = (inOptimistic + 50) / 1000 * 1000;
            setRandoms();
        }

        public void setVariable(string inVariable)
        {
            this.variable = inVariable;
        }
        public string getVariable()
        {
            return this.variable;
        }

        public void setExpectedLowerLimit(int inELL)
        {
            this.expectedLowerLimit = inELL;
        }
        public int getExpectedLowerLimit()
        {
            return this.expectedLowerLimit;
        }

        public void setExpectedUpperLimit(int inEUL)
        {
            this.expectedUpperLimit = inEUL;
        }
        public int getExpectedUpperLimit()
        {
            return this.expectedUpperLimit;
        }

        public void setPessimisticLowerLimit(int inPLL)
        {
            this.pessimisticLowerLimit = inPLL;
        }
        public int getPessimisticLowerLimit()
        {
            return this.pessimisticLowerLimit;
        }

        public void setPessimisticUpperLimit(int inPUL)
        {
            this.pessimisticUpperLimit = inPUL;
        }
        public int getPessimisticUpperLimit()
        {
            return this.pessimisticUpperLimit;
        }

        public void setOptimisticLowerLimit(int inOLL)
        {
            this.optimisticLowerLimit = inOLL;
        }
        public int getOptimisitcLowerLimit()
        {
            return this.optimisticLowerLimit;
        }

        public void setOptimisticUpperLimit(int inOUL)
        {
            this.optimisticUpperLimit = inOUL;
        }
        public int getOptimisticUpperLimit()
        {
            return this.optimisticUpperLimit;
        }

        public void setExpected(int inExpected)
        {
            this.expected = inExpected;
        }
        public int getExpected()
        {
            return this.expected;
        }

        public void setPessimistic(int inPessimistic)
        {
            this.pessimistic = inPessimistic;
        }
        public int getPessimistic()
        {
            return this.pessimistic;
        }

        public void setOptimistic(int inOptimistic)
        {
            this.optimistic = inOptimistic;
        }
        public int getOptimistic()
        {
            return this.optimistic;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as EDdistribution);
        }

        public bool Equals(EDdistribution other)
        {
            return other != null &&
                   variable == other.variable &&
                   expected == other.expected &&
                   pessimistic == other.pessimistic &&
                   optimistic == other.optimistic;
        }

        public override int GetHashCode()
        {
            var hashCode = -1398186836;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(variable);
            hashCode = hashCode * -1521134295 + expected.GetHashCode();
            hashCode = hashCode * -1521134295 + pessimistic.GetHashCode();
            hashCode = hashCode * -1521134295 + optimistic.GetHashCode();
            return hashCode;
        }
    }
}
