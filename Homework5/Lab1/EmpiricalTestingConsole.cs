using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public static class EmpiricalTestingConsole
    {
        private static Output _output;
        static EmpiricalTestingConsole()
        {
            _output = new Output();
        }
        public static void Write(string[] lines)
        {
            _output.WriteData(lines);
        }
    }
}
