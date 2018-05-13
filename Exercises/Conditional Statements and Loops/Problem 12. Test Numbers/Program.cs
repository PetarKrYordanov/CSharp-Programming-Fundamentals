using System;

namespace Problem_12._Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            int combinationCount = 0;
            int sum = 0;

            for (int i = firstNum; i >= 1; i--)
            {
                for (int j = 1; j <= secondNum; j++)
                {
                    sum += 3 * i * j;
                    combinationCount++;
                    if (sum >= controlNumber)
                    {
                        Console.WriteLine($"{combinationCount} combinations");
                        Console.WriteLine($"Sum: {sum} >= {controlNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinationCount} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
