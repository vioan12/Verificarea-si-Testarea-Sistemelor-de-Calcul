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
            if (coefficientA == 0)
            {
                throw new Exception("The 'a' coefficient cannot equal 0");
            }
            A = coefficientA;
            B = coefficientB;
            C = coefficientC;
        }
    }
}
