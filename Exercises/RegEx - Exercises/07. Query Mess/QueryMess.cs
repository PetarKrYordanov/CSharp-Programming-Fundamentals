using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _07._Query_Mess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var query = new Dictionary<string, List<string>>();

            var patternReplace = @"((\+)|(%20))+";
            var pattern = @"(^|\?|\&|\n)([^\?=\&\s]*?)=([^\s\?\&=]+)";

            while (input !="END")
            {
                MatchCollection keyValueCollection = Regex.Matches(input, pattern);

                foreach (Match match in keyValueCollection)
                {
                    var currentKey = match.Groups[2].Value;
                    var currentValue = match.Groups[3].Value;
                    currentKey = Regex.Replace(currentKey, patternReplace, "").Trim();
                    currentValue = Regex.Replace(currentValue, patternReplace, " ").Trim();

                    if (!query.ContainsKey(currentKey))
                    {
                        var list = new List<string>();
                        list.Add(currentValue);
                        query[currentKey] = new List<string>();
                        query[currentKey] = list;
                    }
                    else
                    {
                        query[currentKey].Add(currentValue);
                    }
                }
                foreach (var kvp in query)
                {
                    Console.Write($"{kvp.Key}=[{string.Join(", ",kvp.Value)}]");
                }

                Console.WriteLine();
                query.Clear();
                input = Console.ReadLine();
            }
        }
    }
}
