using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Solution
    {
        public double Root1 { private set; get; }
        public double Root2 { private set; get; }
        public Solution(double root1, double root2)
        {
            EmpiricalTestingConsole.Write(new string[1] { "public Solution(double root1, double root2)" });
            EmpiricalTestingConsole.Write(new string[2] { "root1=" + root1.ToString(), "root2=" + root2.ToString() });
            Root1 = root1;
            EmpiricalTestingConsole.Write(new string[1] { "Root1 = root1" });
            EmpiricalTestingConsole.Write(new string[1] { "Root1=" + Root1.ToString() });
            Root2 = root2;
            EmpiricalTestingConsole.Write(new string[1] { "Root2 = root2" });
            EmpiricalTestingConsole.Write(new string[1] { "Root2=" + Root2.ToString() });
        }
    }
}
