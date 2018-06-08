using System;
using System.Text.RegularExpressions;

namespace _03._Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            var patternSurface = @"(^[^a-z0-9A-Z]+$)";
            var patternMantle = @"(^[0-9_]+$)";
            var patternCore = @"(^[^a-z0-9A-Z]+)([0-9_]+)([a-zA-Z]+)([0-9_]+)([^a-z0-9A-Z]+$)";
            var bestLen = 0;


            for (int i = 0; i < 5; i++)
            {
                string line = Console.ReadLine();

                if (i == 0 || i == 4)
                {
                    ValidatePettern(line, patternSurface);
                }
                else if (i == 1 || i == 3)
                {
                    ValidatePettern(line, patternMantle);
                }
                else
                {
                    ValidatePettern(line, patternCore);
                    Match match = Regex.Match(line, patternCore);
                    bestLen = match.Groups[3].Length;
                }
            }
            Console.WriteLine("Valid");
            Console.WriteLine(bestLen);
        }

        private static void ValidatePettern(string line, string pattern)
        {
            Match match = Regex.Match(line, pattern);
            if (match.Success)
            {
                return;
            }
            Console.WriteLine("Invalid");
            Environment.Exit(0);
        }
    }
}
