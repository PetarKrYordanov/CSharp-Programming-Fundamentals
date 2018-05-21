using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Anonymous_Vox
{
    class Vox
    {
        static void Main(string[] args)
        {
            {
                string inputText = Console.ReadLine();
                var replaceWords = Console.ReadLine()
                    .Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                int i = 0;
                var RES = String.Empty;

                string pattern = @"(?<=^|.)(([A-Za-z]+)(.*)\2)(?=$|.*)(([A-Za-z]+)(.*)\2)*(?=$|.*)";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(inputText);
                List<string> match = new List<string>();

                foreach (Match item in matches)
                {
                    match.Add(item.Groups[2].Value);
                    RES = Regex.Replace(inputText, item.Groups[3].Value, replaceWords[i], RegexOptions.Multiline);
                    inputText = RES;
                    i++;
                }
                Console.WriteLine(RES);
            }
        }
}
