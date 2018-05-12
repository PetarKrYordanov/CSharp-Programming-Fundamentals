using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Sum_Reversed_Numbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < inputNumbers.Length; i++)
            {

                var currentNumber = inputNumbers[i];
                var currentNumberString = currentNumber.ToString();
                var reversedNumberArray = currentNumberString.Reverse().ToArray();
                var reversedNumberString = new string(reversedNumberArray);
                inputNumbers[i] = int.Parse(reversedNumberString);
            }

            Console.WriteLine(inputNumbers.Sum());
        }
    }
}
