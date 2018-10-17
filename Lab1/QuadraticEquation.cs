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
                return (double)(Math.Pow(Coefficients.B, 2) - 4 * Coefficients.A * Coefficients.C);
            }
        }
        public QuadraticEquation (Coefficients coefficients)
        {
            if(coefficients != null)
            {
                Coefficients = coefficients;
            }
            else
            {
                throw new Exception("'coefficients' cannot be null");
            }
        }
        public Solution SolveWithRealSolutions()
        {
            Solution solution;
            if (Delta == 0)
            {
                solution = new Solution(
                    (double)(-Coefficients.B) / (double)(2 * Coefficients.A),
                    (double)(-Coefficients.B) / (double)(2 * Coefficients.A)
                    );
                return solution;
            }
            if(Delta > 0)
            {
                solution = new Solution(
                    (double)(-Coefficients.B + Math.Sqrt(Delta)) / (double)(2 * Coefficients.A),
                    (double)(-Coefficients.B - Math.Sqrt(Delta)) / (double)(2 * Coefficients.A)
                    );
                return solution;
            }
            return null;
        }
    }
}
