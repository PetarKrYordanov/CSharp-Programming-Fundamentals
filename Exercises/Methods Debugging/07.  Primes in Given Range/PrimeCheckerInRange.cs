using System;
using System.Collections.Generic;

namespace _07.__Primes_in_Given_Range
{
    class PrimeCheckerInRange
    {
        static void Main(string[] args)
        {
            var startNumber = int.Parse(Console.ReadLine());
            var endNumber = int.Parse(Console.ReadLine());

            var result = new List<int>();

            for (int currentNumber = startNumber; currentNumber <= endNumber; currentNumber++)
            {
                bool checkCurrentNumber = isPrime(currentNumber);

                if (checkCurrentNumber)
                {
                    result.Add(currentNumber);
                }
            }
            Console.WriteLine(string.Join(", ", result));
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
