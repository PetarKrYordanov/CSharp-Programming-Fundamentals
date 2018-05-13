using System;
using System.Numerics;
namespace _13._Factorial
{
    class Factorial
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
            Console.WriteLine(sum);
        }
    }
}
