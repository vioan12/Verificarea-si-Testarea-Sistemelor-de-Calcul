using System;

namespace Lab1
{
    public class Output
    {
        public virtual void WriteData(string[] lines)
        {
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}