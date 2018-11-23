using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class QuadraticEquation
    {
        //ax^2 + bx + c = 0
        public Coefficients Coefficients { private set; get; }
        public double Delta
        {
            get
            {
                EmpiricalTestingConsole.Write(new string[2] { "public double Delta", "get" });
                return (double)(Math.Pow(Coefficients.B, 2) - 4 * Coefficients.A * Coefficients.C);
            }
        }
        public QuadraticEquation (Coefficients coefficients)
        {
            EmpiricalTestingConsole.Write(new string[1] { "public QuadraticEquation (Coefficients coefficients)" });
            EmpiricalTestingConsole.Write(new string[1] { "coefficients=" + coefficients.ToString() });
            EmpiricalTestingConsole.Write(new string[3] { "A=" + coefficients.A, "B=" + coefficients.B, "C=" + coefficients.C });
            if (coefficients != null)
            {
                EmpiricalTestingConsole.Write(new string[1] { "if (coefficients != null)" });
                Coefficients = coefficients;
                EmpiricalTestingConsole.Write(new string[1] { "Coefficients = coefficients" });
                EmpiricalTestingConsole.Write(new string[1] { "Coefficients=" + Coefficients.ToString() });
                EmpiricalTestingConsole.Write(new string[3] { "A=" + Coefficients.A, "B=" + Coefficients.B, "C=" + Coefficients.C });
            }
            else
            {
                EmpiricalTestingConsole.Write(new string[1] { "else" });
                throw new Exception("'coefficients' cannot be null");
            }
        }
        public Solution SolveWithRealSolutions()
        {
            EmpiricalTestingConsole.Write(new string[1] { "public Solution SolveWithRealSolutions()" });
            Solution solution = null;
            EmpiricalTestingConsole.Write(new string[1] { "Solution solution = null" });
            if (Delta.Equals(0))
            {
                EmpiricalTestingConsole.Write(new string[1] { "if (Delta.Equals(0))" });
                solution = new Solution(
                    (double)(-Coefficients.B) / (double)(2 * Coefficients.A),
                    (double)(-Coefficients.B) / (double)(2 * Coefficients.A)
                    );
                EmpiricalTestingConsole.Write(new string[4]
                {
                    "solution = new Solution(",
                    "(double)(-Coefficients.B) / (double)(2 * Coefficients.A),",
                    "(double)(-Coefficients.B) / (double)(2 * Coefficients.A)",
                    ")"
                });
                EmpiricalTestingConsole.Write(new string[1] { "solution=" + solution.ToString() });
                EmpiricalTestingConsole.Write(new string[2] { "solution.Root1=" + solution.Root1.ToString(), "solution.Root2=" + solution.Root2.ToString() });
            }
            if (Delta > 0)
            {
                EmpiricalTestingConsole.Write(new string[1] { " if(Delta > 0)" });
                solution = new Solution(
                    (double)(-Coefficients.B + Math.Sqrt(Delta)) / (double)(2 * Coefficients.A),
                    (double)(-Coefficients.B - Math.Sqrt(Delta)) / (double)(2 * Coefficients.A)
                    );
                EmpiricalTestingConsole.Write(new string[4]
                {
                    "solution = new Solution(",
                    "(double)(-Coefficients.B + Math.Sqrt(Delta)) / (double)(2 * Coefficients.A),",
                    "(double)(-Coefficients.B - Math.Sqrt(Delta)) / (double)(2 * Coefficients.A)",
                    ")"
                });
                EmpiricalTestingConsole.Write(new string[1] { "solution=" + solution.ToString() });
                EmpiricalTestingConsole.Write(new string[2] { "solution.Root1=" + solution.Root1.ToString(), "solution.Root2=" + solution.Root2.ToString() });
            }
            if (Delta < 0)
            {
                EmpiricalTestingConsole.Write(new string[1] { " if (Delta < 0)" });
                throw new Exception("the equation do not have a real solution");
            }
            return solution;
        }
    }
}
