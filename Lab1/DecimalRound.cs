using System;

namespace Lab1
{
    public static class Decimals
    {
        public static string[] Round(Solution solution, int numberDecimals)
        {
            string[] roots;
            roots = new string[2]
            {
                (Math.Truncate(Math.Pow(10,numberDecimals) * solution.Root1) / (double) Math.Pow(10,numberDecimals)).ToString(),
                (Math.Truncate(Math.Pow(10,numberDecimals) * solution.Root2) / (double) Math.Pow(10,numberDecimals)).ToString(),
            };
            return roots;
        }
    }
}