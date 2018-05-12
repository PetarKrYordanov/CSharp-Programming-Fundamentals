using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Character_Multiplier
{
    class CharMultiply
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

            var result = MultiplyCharacters(input);           
            Console.WriteLine(result);
        }

        private static int MultiplyCharacters(string[] input)
        {
            int result=0;
            
            var firstString = input[0];
            var secondString = input[1];
            var minLength = Math.Min(firstString.Length, secondString.Length);
            var maxLength = Math.Max(firstString.Length, secondString.Length);

            for (int i = 0; i < minLength; i++)
            {
                result += ((int)firstString[i] * (int)secondString[i]);
            }

            if (minLength != maxLength)
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    string longerString = input.OrderByDescending(x => x.Length).First();
                    result += (int)longerString[i];
                }
            }
            return result;
        }
    }
}
