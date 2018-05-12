using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Key_Replacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            string pattern = @"([a-zA-Z]+)([\\\|<])(.*)([\\\|<])([a-zA-Z]+)";

            Match myMatch = Regex.Match(input, pattern);
            var startKey = myMatch.Groups[1].Value;
            var endKey = myMatch.Groups[5].Value;

            var inputTwo = Console.ReadLine();

            var patternTwo = $@"{startKey}(.*?){endKey}";
            Regex regex = new Regex(patternTwo);

            var result = new List<string>();

            MatchCollection matchCollection = regex.Matches(inputTwo);

            foreach (Match match in matchCollection)
            {
                if (regex.IsMatch(inputTwo))
                {
                    result.Add(match.Groups[1].Value);
                }
            }

            if (!result.Any())
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(string.Join("", result));
            }
        }
    }
}
