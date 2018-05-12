using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Magic_exchangeable_words
{
    class MagicWords
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var firstStr = input[0];
            var secondStr = input[1];

            string isMagic = IsExchangeable(firstStr, secondStr);
            Console.WriteLine(isMagic);
        }

        private static String IsExchangeable(string firstStr, string secondStr)
        {
            var exchangeWords = new Dictionary<char, char>();

            int minLength = Math.Min(firstStr.Length, secondStr.Length);

            if (firstStr.Distinct().Count() != secondStr.Distinct().Count())
            {
                return "false";   
            }
            else if (firstStr.Distinct().Count() == secondStr.Distinct().Count() && firstStr.Length != secondStr.Length)
            {
                return "true";
            }
            else if (true)
            {

                for (int i = 0; i < minLength; i++)
                {
                    var charOne = firstStr[i];
                    var charTwo = secondStr[i];

                    if (!exchangeWords.ContainsKey(charOne) && !exchangeWords.ContainsValue(charTwo))
                    {
                        exchangeWords[charOne] = charTwo;
                        continue;
                    }
                    else if (exchangeWords.ContainsKey(charOne))
                    {
                        if (charTwo  == exchangeWords[charOne])
                        {
                            continue;
                        }
                        else
                        {
                            return "false";
                        }
                    }
                }
            }
            return "true";
        }
    }
}
