using System;

namespace Lab1
{
    public class Input
    {
        public virtual string ReadDataByLine()
        {
            EmpiricalTestingConsole.Write(new string[1] { "public virtual string ReadDataByLine()"});
            return Console.ReadLine();
        }
    }
}