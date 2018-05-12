using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Extract_Sentences_by_Keyword
{
    class ExtractByKeyword
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();
            string pattern = $@"\b{word}\b";
            var sentences = text
                .Trim()
                .Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence,pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
