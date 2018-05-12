using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Camera_View
{
    class CameraView
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            var text = Console.ReadLine();
            int toTake = inputNumbers[1];
            int toSkip = inputNumbers[0];

            var pattern = @"\|<([\w]{"+toSkip+@"})([\w]{0,"+toTake+@"})";

            var result = new List<string>();

            MatchCollection matchCollection = Regex.Matches(text, pattern);

            foreach (Match match in matchCollection)
            {
                result.Add(match.Groups[2].Value);
            }
 
            Console.WriteLine(String.Join(", ",result));
        }
    }
}
