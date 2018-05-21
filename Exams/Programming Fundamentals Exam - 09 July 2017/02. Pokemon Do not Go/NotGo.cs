using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Pokemon_Do_not_Go
{
    class NotGo
    {
        static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var index = int.Parse(Console.ReadLine());

            long sum = 0L;

            while (true)
            {
                bool isNegative = false;
                bool isOberListLength = false;

                if (index < 0)
                {
                    index = 0;
                    isNegative = true;
                }
                if (index > inputNumbers.Count - 1)
                {
                    index = inputNumbers.Count - 1;
                    isOberListLength = true;
                }
                var elementToRemove = inputNumbers[index];

                if (inputNumbers.Count == 1)
                {
                    sum += inputNumbers[0];
                    break;
                }
                inputNumbers.RemoveAt(index);
                sum += elementToRemove;

                for (int i = 0; i < inputNumbers.Count; i++)
                {
                    if (inputNumbers[i] <= elementToRemove)
                    {
                        inputNumbers[i] += elementToRemove;
                    }
                    else
                    {
                        inputNumbers[i] -= elementToRemove;
                    }
                }
                if (isNegative)
                {
                    int numberToAdd = inputNumbers[inputNumbers.Count - 1];
                    inputNumbers.Insert(0, numberToAdd);
                }

                if (isOberListLength)
                {
                    int numberToAdd = inputNumbers[0];
                    inputNumbers.Insert(inputNumbers.Count, numberToAdd);
                }
                index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
