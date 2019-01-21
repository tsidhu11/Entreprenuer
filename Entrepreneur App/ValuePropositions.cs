using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrepreneur_App
{
    public class ValuePropositions : IEquatable<ValuePropositions>
    {
        private string explanation;
        private double valuePropMath;

        public ValuePropositions(string inExplanation, double inValue)
        {
            this.explanation = inExplanation;
            this.valuePropMath = inValue;
        }

        public void setExplanation(string inExplanation)
        {
            this.explanation = inExplanation;
        }
        public string getExplanation()
        {
            return this.explanation;
        }

        public void setValuePropMath(double inValue)
        {
            this.valuePropMath = inValue;
        }
        public double getValuePropMath()
        {
            return this.valuePropMath;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ValuePropositions);
        }

        public bool Equals(ValuePropositions other)
        {
            return other != null &&
                   explanation == other.explanation &&
                   valuePropMath == other.valuePropMath;
        }

        public override int GetHashCode()
        {
            var hashCode = 381426917;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(explanation);
            hashCode = hashCode * -1521134295 + valuePropMath.GetHashCode();
            return hashCode;
        }
    }
}
