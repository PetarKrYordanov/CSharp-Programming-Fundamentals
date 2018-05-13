using System;

namespace _6._Prime_Checker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());

            Console.WriteLine(isPrime(number));
        }

        static bool isPrime(long n)
        {
            bool primeChecker = true;
            var rootSquare = Math.Sqrt(n);

            if (n == 1 || n == 0)
            {
                return false;
            }

            for (int index = 2; index <= rootSquare; index++)
            {
                if (n % index == 0)
                {
                    return false;
                }
            }
            return primeChecker;
        }
    }
}
