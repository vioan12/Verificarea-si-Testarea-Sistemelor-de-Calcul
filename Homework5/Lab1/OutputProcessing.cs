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
            EmpiricalTestingConsole.Write(new string[1] { "public OutputProcessing(Output output)" });
            _output = output;
            EmpiricalTestingConsole.Write(new string[1] { "_output = output" });
            EmpiricalTestingConsole.Write(new string[1] { "_output=" + output.ToString() });
        }
        public void PutData(Solution solution)
        {
            EmpiricalTestingConsole.Write(new string[1] { "public void PutData(Solution solution)" });
            EmpiricalTestingConsole.Write(new string[1] { "solution=" + solution.ToString() });
            EmpiricalTestingConsole.Write(new string[2] { "solution.Root1=" + solution.Root1.ToString(), "solution.Root2=" + solution.Root2.ToString() });
            string line1, line2;
            EmpiricalTestingConsole.Write(new string[1] { "string line1, line2" });
            string[] newSolution = Decimals.Round(solution, 2);
            EmpiricalTestingConsole.Write(new string[1] { "string[] newSolution = Decimals.Round(solution, 2)" });
            EmpiricalTestingConsole.Write(new string[2] { "newSolution[0]=" + newSolution[0], "newSolution[1]=" + newSolution[1] });
            line1 = "x1=" + newSolution[0];
            EmpiricalTestingConsole.Write(new string[1] { "line1 = "+"x1 = "+" + newSolution[0]" });
            EmpiricalTestingConsole.Write(new string[1] { "line1=" + line1 });
            line2 = "x2=" + newSolution[1];
            EmpiricalTestingConsole.Write(new string[1] { "line2 = "+"x2 = "+" + newSolution[1]" });
            EmpiricalTestingConsole.Write(new string[1] { "line2=" + line2 });
            _output.WriteData(new string[2] {line1, line2});
            EmpiricalTestingConsole.Write(new string[1] { "_output.WriteData(new string[2] {line1, line2})" });
        }
    }
}
