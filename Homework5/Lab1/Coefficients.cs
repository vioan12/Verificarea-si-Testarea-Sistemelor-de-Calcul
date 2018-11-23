using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Coefficients
    {
        public int A { private set; get; }
        public int B { private set; get; }
        public int C { private set; get; }
        public Coefficients(int coefficientA, int coefficientB, int coefficientC)
        {
            EmpiricalTestingConsole.Write(new string[1] {"public Coefficients(int coefficientA, int coefficientB, int coefficientC)"});
            EmpiricalTestingConsole.Write(new string[1] { "coefficientA=" + coefficientA.ToString() });
            EmpiricalTestingConsole.Write(new string[1] { "coefficientB=" + coefficientB.ToString() });
            EmpiricalTestingConsole.Write(new string[1] { "coefficientB=" + coefficientB.ToString() });
            if (coefficientA == 0)
            {
                EmpiricalTestingConsole.Write(new string[1] { "if (coefficientA == 0)" });
                throw new Exception("The 'a' coefficient cannot equal 0");
            }
            A = coefficientA;
            EmpiricalTestingConsole.Write(new string[1] { "A = coefficientA" });
            EmpiricalTestingConsole.Write(new string[1] { "A=" + A.ToString()});
            B = coefficientB;
            EmpiricalTestingConsole.Write(new string[1] { "B = coefficientB" });
            EmpiricalTestingConsole.Write(new string[1] { "B=" + B.ToString() });
            C = coefficientC;
            EmpiricalTestingConsole.Write(new string[1] { "C = coefficientC" });
            EmpiricalTestingConsole.Write(new string[1] { "C=" + C.ToString() });
        }
    }
}
