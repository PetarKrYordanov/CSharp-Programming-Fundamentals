using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Search_for_a_Number
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] conditions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<int> result = new List<int>();

            int elementsToTake = conditions[0];
            int elementsToDelete = conditions[1];

            result = inputNumbers.Take(elementsToTake).ToList();

            for (int i = 0; i < elementsToDelete; i++)
            {
                result.RemoveAt(0);
            }

            if (result.Contains(conditions[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
