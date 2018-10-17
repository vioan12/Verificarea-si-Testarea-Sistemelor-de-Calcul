using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Input input = new Input();
                Output output = new Output();
                QuadraticEquation quadraticEquation = new QuadraticEquation(input.GetData());
                Solution solution = quadraticEquation.SolveWithRealSolutions();
                output.PutData(solution);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
