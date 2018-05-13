using System;
using System.Numerics;

namespace _14._Factorial_Trailing_Zeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger sum = 1;

            while (n > 1)
            {
                sum *= n;
                n--;
            }

            long trailingZeroes = CountTrailingZeroes(sum);
            Console.WriteLine(trailingZeroes);
        }

        private static long CountTrailingZeroes(BigInteger sum)
        {
            long counter = 0;

            while (sum % 10 == 0)
            {
                counter++;
                sum /= 10;
            }
            return counter;
        }
    }
}
