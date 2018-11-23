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
            EmpiricalTestingConsole.Write(new string[1] { "public InputProcessing(Input input, Output output)" });
            EmpiricalTestingConsole.Write(new string[2] { "input=" + input.ToString(), "output=" + output.ToString() });
            _input = input;
            EmpiricalTestingConsole.Write(new string[1] { " _input = input" });
            EmpiricalTestingConsole.Write(new string[1] { "_input=" + _input.ToString() });
            _output = output;
            EmpiricalTestingConsole.Write(new string[1] { "_output = output" });
            EmpiricalTestingConsole.Write(new string[1] { "_output=" + _output.ToString() });
        }
        public Coefficients GetData()
        {
            EmpiricalTestingConsole.Write(new string[1] { "public Coefficients GetData()" });
            Coefficients coefficients = new Coefficients(
                SetCoefficient('a', Constants.CoefficientAMinimumValue, Constants.CoefficientAMaximumValue), 
                SetCoefficient('b', Constants.CoefficientBMinimumValue, Constants.CoefficientBMaximumValue),
                SetCoefficient('c', Constants.CoefficientCMinimumValue, Constants.CoefficientCMaximumValue)
                );
            EmpiricalTestingConsole.Write(new string[5]
            {
                "Coefficients coefficients = new Coefficients(",
                "SetCoefficient('a', Constants.CoefficientAMinimumValue, Constants.CoefficientAMaximumValue)",
                "SetCoefficient('b', Constants.CoefficientBMinimumValue, Constants.CoefficientBMaximumValue)",
                "SetCoefficient('c', Constants.CoefficientCMinimumValue, Constants.CoefficientCMaximumValue)",
                ")"
            });
            EmpiricalTestingConsole.Write(new string[1] { "coefficients=" + coefficients.ToString() });
            EmpiricalTestingConsole.Write(new string[3] 
            {
                "coefficients.A=" + coefficients.A,
                "coefficients.B=" + coefficients.B,
                "coefficients.C=" + coefficients.C
            });
            return coefficients;
        }
        private int SetCoefficient(char c, int minimumValue, int maximumValue)
        {
            EmpiricalTestingConsole.Write(new string[1] { "private int SetCoefficient(char c, int minimumValue, int maximumValue)" });
            EmpiricalTestingConsole.Write(new string[3] 
            {
                "c=" + c,
                "minimumValue=" + minimumValue.ToString(),
                "maximumValue=" + maximumValue.ToString()
            });
            int coefficient;
            EmpiricalTestingConsole.Write(new string[1] { "int coefficient" });
            if (_output != null)
            {
                EmpiricalTestingConsole.Write(new string[1] { "if (_output != null)" });
                string line = c + "=";
                EmpiricalTestingConsole.Write(new string[1] { "string line = c + " + "=" });
                EmpiricalTestingConsole.Write(new string[1] { "line=" + line });
                _output.WriteData(new string[1] {line});
                EmpiricalTestingConsole.Write(new string[1] { "_output.WriteData(new string[1] {line})" });
            }
            try
            {
                EmpiricalTestingConsole.Write(new string[1] { "try" });
                coefficient = Int32.Parse(_input.ReadDataByLine());
                EmpiricalTestingConsole.Write(new string[1] { "coefficient = Int32.Parse(_input.ReadDataByLine())" });
                EmpiricalTestingConsole.Write(new string[1] { "coefficient=" + coefficient });
            }
            catch (FormatException)
            {
                EmpiricalTestingConsole.Write(new string[1] { "catch (FormatException)" });
                throw new Exception(c+" is not integer");
            }
            if(!(coefficient>=minimumValue && coefficient<=maximumValue))
            {
                EmpiricalTestingConsole.Write(new string[1] { "if(!(coefficient>=minimumValue && coefficient<=maximumValue))" });
                throw new Exception(c + " out of range");
            }
            return coefficient;
        }
    }
}
