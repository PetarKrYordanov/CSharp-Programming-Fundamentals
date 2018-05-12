using System;
using System.Linq;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] secondArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            int equalElementsStart = SearchForEqualElements(firstArray, secondArray);

            Array.Reverse(firstArray);
            Array.Reverse(secondArray);

            int equalElementEnd = SearchForEqualElements(firstArray, secondArray);

            if (equalElementEnd > equalElementsStart)
            {
                Console.WriteLine(equalElementEnd);
            }
            else
            {
                Console.WriteLine(equalElementsStart);
            }

        }

        private static int SearchForEqualElements(string[] firstArray, string[] secondArray)
        {
            int minLength = Math.Min(firstArray.Length, secondArray.Length);
            int equalElementCounter = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    equalElementCounter++;
                }
            }
            return equalElementCounter;
        }
    }
}
