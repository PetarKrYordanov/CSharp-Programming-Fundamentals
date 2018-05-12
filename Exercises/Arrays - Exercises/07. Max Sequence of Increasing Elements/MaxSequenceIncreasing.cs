using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Max_Sequence_of_Increasing_Elements
{
    class MaxSequenceIncreasing
    {
        static void Main()
        {

            int[] sequenceNumber = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;
            List<int> result = new List<int>();

            for (int i = 1; i <= sequenceNumber.Length - 1; i++)
            {
                if (sequenceNumber[i - 1] < sequenceNumber[i])
                {
                    len++;

                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                }
                else
                {
                    start = i;
                    len = 1;
                }

            }
            for (int i = bestStart; i < bestLen + bestStart; i++)
            {
                Console.Write(sequenceNumber[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
