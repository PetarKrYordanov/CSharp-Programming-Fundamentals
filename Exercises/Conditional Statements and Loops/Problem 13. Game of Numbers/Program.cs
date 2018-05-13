using System;
using System.Collections.Generic;

namespace Problem_13._Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            var numberfound = new Stack<string>();
            int combinationCounter = 0;
            bool isFoundNumber = false;

            for (int i = startNumber; i <= endNumber; i++)
            {
                for (int j = startNumber; j <= endNumber; j++)
                {
                    combinationCounter++;
                    if (i + j == magicNumber)
                    {
                        isFoundNumber = true;
                        numberfound.Push($"Number found! {i} + {j} = {magicNumber}");
                    }
                }
            }
            if (isFoundNumber)
            {
                Console.WriteLine(numberfound.Pop());
            }
            else
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
