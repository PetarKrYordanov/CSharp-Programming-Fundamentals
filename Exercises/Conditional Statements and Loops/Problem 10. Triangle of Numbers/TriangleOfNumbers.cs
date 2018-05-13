using System;

namespace Problem_10._Triangle_of_Numbers
{
    class TriangleOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 1; i <=n; i++)
            {
                for (int j =1; j <= i; j++)
                {
                    Console.Write(num);
                    Console.Write(" ");
                }
                Console.WriteLine();
                num++;
            }
        }
    }
}
