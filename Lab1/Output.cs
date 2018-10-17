using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Output
    {
        public Output() { }
        public void PutData(Solution solution)
        {
            if (solution != null)
            {
                Console.WriteLine("x1=" + (Math.Truncate(100 * solution.Root1)/(double)100).ToString());
                Console.WriteLine("x2=" + (Math.Truncate(100 * solution.Root2)/(double)100).ToString());
            }
            else
            {
                throw new Exception("the equation do not have a real solution");
            }
        }
    }
}
