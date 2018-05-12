using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Longest_Increasing_Subsequence
{
    class LIS
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int numbersCount = numbers.Count;

            int[] lengts = new int[numbersCount];

            var previousLongestEndIndex = lengts
                .Select(n => n - 1)
                .ToArray();

            var bestLength = 0;
            var lastIndex = -1;

            for (int i = 1; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                for (int j = 0; j < i; j++)
                {
                    var sequenceNumber = numbers[j];

                    if (sequenceNumber<currentNumber && lengts[j]==lengts[i])
                    {
                        lengts[i]++;
                        previousLongestEndIndex[i] = j;
                    }

                    if (lengts[i]> bestLength)
                    {
                        bestLength = lengts[i];
                        lastIndex = i;
                    }
                }

            }

            var maxSubsequenceIndex = Array.IndexOf(lengts, lengts.Max());
            var maxSubsequence = new List<int>();

            for (int i = maxSubsequenceIndex; i>=0;)
            {
                maxSubsequence.Add(numbers[i]);
                i = previousLongestEndIndex[i];
            }

            maxSubsequence.Reverse();
            Console.WriteLine(string.Join(" ", maxSubsequence));


        }
    }
}
