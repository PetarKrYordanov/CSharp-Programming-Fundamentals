using System;
using System.Linq;

namespace _07._Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine()
                .TrimStart('0')
                .ToCharArray()
                .Select(s => ((int)s - '0')).ToArray();

            var multiplier = int.Parse(Console.ReadLine());
            Array.Reverse(number);

            int reminder = 0;
            string result = "";

            if (multiplier ==0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < number.Length; i++)
            {
                int sum = multiplier * number[i]+reminder;
                int currentDigit = sum % 10;
                reminder = sum / 10;
                result += currentDigit;

                if (i == number.Length-1 && reminder !=0)
                {
                    result += reminder;
                }
            }
            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }

            Console.WriteLine();
        }
    }
}
