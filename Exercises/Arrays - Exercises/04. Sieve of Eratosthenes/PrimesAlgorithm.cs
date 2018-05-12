using System;
using System.Collections.Generic;

namespace _04._Sieve_of_Eratosthenes
{
    class PrimesAlgorithm
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SieveAlgorith(n);
        }

        static void SieveAlgorith(int n)
        {
            bool[] isPrime = new bool[n + 1];
            var result = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }
            Console.WriteLine();

            for (int i = 2; i < isPrime.Length; i++)
            {
                if (isPrime[i])
                {
                    result.Add(i);
                }
                int indexMaker = i;

                while (indexMaker < isPrime.Length)
                {
                    isPrime[indexMaker] = false;
                    indexMaker += i;
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
