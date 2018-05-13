using System;
using System.Linq;

namespace _4._Numbers_in_Reversed_Order
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            var numAsString = Console.ReadLine();

            var result = ReverseString(numAsString);

            Console.WriteLine(result);
        }

        private static string ReverseString(string numAsString)
        {
            string result = string.Empty;

            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                result += numAsString[i];
            }
            return result;
        }
    }
}
