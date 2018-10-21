using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class InputProcessing
    {
        private Input _input;
        private Output _output;
        public InputProcessing(Input input, Output output)
        {
            _input = input;
            _output = output;
        }
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
            if (_output != null)
            {
                string line = c + "=";
                _output.WriteData(new string[1] {line});
            }
            try
            {
                coefficient = Int32.Parse(_input.ReadDataByLine());
            }
            catch (FormatException)
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
