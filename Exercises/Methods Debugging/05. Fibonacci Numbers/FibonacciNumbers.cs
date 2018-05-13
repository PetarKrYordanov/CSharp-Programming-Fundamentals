using System;

namespace _05._Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(number));
        }
        static long Fib(int number)
        {
            if (number<=1)
            {
                return 1l;
            }
            else
            {
                return (Fib(number - 1) + Fib(number - 2));
            }
        }
    }
}
