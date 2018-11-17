using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class OutputProcessing
    {
        private Output _output;
        public OutputProcessing(Output output)
        {
            _output = output;
        }
        public void PutData(Solution solution)
        {
            string line1, line2;
            string[] newSolution = Decimals.Round(solution, 2);
            line1 = "x1=" + newSolution[0];
            line2 = "x2=" + newSolution[1];
            _output.WriteData(new string[2] {line1, line2});
        }
    }
}
