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
                InputProcessing inputProcessing = new InputProcessing(new Input(), new Output());
                OutputProcessing outputProcessing = new OutputProcessing(new Output());
                QuadraticEquation quadraticEquation = new QuadraticEquation(inputProcessing.GetData());
                outputProcessing.PutData(quadraticEquation.SolveWithRealSolutions());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
