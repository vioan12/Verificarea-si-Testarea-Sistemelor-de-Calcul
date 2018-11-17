using System;

namespace Lab1
{
    public static class Decimals
    {
        public static string[] Round(Solution solution, int numberDecimals)
        {
            EmpiricalTestingConsole.Write(new string[1] { "public static string[] Round(Solution solution, int numberDecimals)" });
            EmpiricalTestingConsole.Write(new string[1] { "solution=" + solution.ToString() });
            EmpiricalTestingConsole.Write(new string[2] { "solution.Root1=" + solution.Root1.ToString(), "solution.Root2=" + solution.Root2.ToString() });
            EmpiricalTestingConsole.Write(new string[1] { "numberDecimals=" + numberDecimals.ToString() });
            string[] roots;
            EmpiricalTestingConsole.Write(new string[1] { "string[] roots" });
            roots = new string[2]
            {
                (Math.Truncate(Math.Pow(10,numberDecimals) * solution.Root1) / (double) Math.Pow(10,numberDecimals)).ToString(),
                (Math.Truncate(Math.Pow(10,numberDecimals) * solution.Root2) / (double) Math.Pow(10,numberDecimals)).ToString(),
            };
            EmpiricalTestingConsole.Write(new string[5] 
            {
                "roots = new string[2]",
                "{",
                "(Math.Truncate(Math.Pow(10,numberDecimals) * solution.Root1) / (double) Math.Pow(10,numberDecimals)).ToString(),",
                "(Math.Truncate(Math.Pow(10,numberDecimals) * solution.Root2) / (double) Math.Pow(10,numberDecimals)).ToString(),",
                "};"

            });
            EmpiricalTestingConsole.Write(new string[2] { "roots[0]=" + roots[0], "roots[1]=" + roots[1] });
            return roots;
        }
    }
}