using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Input
    {
        public Input() { }
        public Coefficients GetData()
        {
            Coefficients coefficients = new Coefficients(
                SetCoefficient('a', Constants.CoefficientAMinimumValue, Constants.CoefficientAMaximumValue), 
                SetCoefficient('b', Constants.CoefficientBMinimumValue, Constants.CoefficientBMaximumValue),
                SetCoefficient('c', Constants.CoefficientCMinimumValue, Constants.CoefficientCMaximumValue)
                );
            return coefficients;
        }
        private int SetCoefficient(char c, int minimumValue, int maximumValue)
        {
            int coefficient;
            Console.WriteLine(c+"=");
            try
            {
                coefficient = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                throw new Exception(c+" is not integer");
            }
            if(!(coefficient>=minimumValue && coefficient<=maximumValue))
            {
                throw new Exception(c + " out of range");
            }
            return coefficient;
        }
    }
}
