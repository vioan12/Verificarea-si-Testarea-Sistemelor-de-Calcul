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
            EmpiricalTestingConsole.Write(new string[1] { "static void Main(string[] args)" });
            try
            {
                EmpiricalTestingConsole.Write(new string[1] { "try" });
                InputProcessing inputProcessing = new InputProcessing(new Input(), new Output());
                EmpiricalTestingConsole.Write(new string[1] { "InputProcessing inputProcessing = new InputProcessing(new Input(), new Output())" });
                EmpiricalTestingConsole.Write(new string[1] { "inputProcessing=" + inputProcessing.ToString() });
                OutputProcessing outputProcessing = new OutputProcessing(new Output());
                EmpiricalTestingConsole.Write(new string[1] { "OutputProcessing outputProcessing = new OutputProcessing(new Output())" });
                EmpiricalTestingConsole.Write(new string[1] { "outputProcessing=" + outputProcessing.ToString() });
                QuadraticEquation quadraticEquation = new QuadraticEquation(inputProcessing.GetData());
                EmpiricalTestingConsole.Write(new string[1] { "QuadraticEquation quadraticEquation = new QuadraticEquation(inputProcessing.GetData())" });
                EmpiricalTestingConsole.Write(new string[1] { "quadraticEquation=" + quadraticEquation.ToString() });
                outputProcessing.PutData(quadraticEquation.SolveWithRealSolutions());
                EmpiricalTestingConsole.Write(new string[1] { "outputProcessing.PutData(quadraticEquation.SolveWithRealSolutions())" });
            }
            catch (Exception e)
            {
                EmpiricalTestingConsole.Write(new string[1] { "catch (Exception e)" });
                Console.WriteLine(e.Message);
                EmpiricalTestingConsole.Write(new string[1] { "Console.WriteLine(e.Message)" });
            }
        }
    }
}
