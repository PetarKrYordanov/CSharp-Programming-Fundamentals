using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            double sum = 0;

            foreach (var item in input)
            {
                var firstLetter = item.First();
                var secondLetter = item.Last();
                var number = int.Parse(item.Substring(1, item.Length - 2));
               double currentSum;

                if (Char.IsUpper(firstLetter))
                {
                    var divider = firstLetter - 'A' + 1.0;
                    currentSum = number / divider;
                }
                else
                {
                    var multiplier = firstLetter - 'a' + 1.0;
                    currentSum = number * multiplier;
                }

                if (Char.IsUpper(secondLetter))
                {
                    var substrackNumber = secondLetter - 'A' + 1.0;
                    currentSum = currentSum - substrackNumber;
                }
                else
                {
                    var numberToAdd = secondLetter - 'a' + 1.0;
                    currentSum = currentSum + numberToAdd;
                }
                sum += currentSum;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
