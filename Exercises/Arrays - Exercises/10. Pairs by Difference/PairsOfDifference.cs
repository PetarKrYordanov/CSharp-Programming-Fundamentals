using System;
using System.Linq;

namespace _10._Pairs_by_Difference
{
    class PairsOfDifference
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int difference = int.Parse(Console.ReadLine());

            int resullt = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentDigit = arr[i];

                for (int j = i; j < arr.Length; j++)
                {
                    if (Math.Abs(currentDigit - arr[j]) == difference)
                    {
                        resullt++;
                    }
                }
            }
            Console.WriteLine(resullt);
        }
    }
}
