using System;

namespace Problem_9._Count_the_Integers
{
    class CountIntegers
    {
        static void Main(string[] args)
        {
            int countOfIntegers = 0;
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    int integer = int.Parse(Console.ReadLine());
                    countOfIntegers++;
                }
                catch (Exception)
                {
                    break;
                }
            }
            Console.WriteLine(countOfIntegers);
        }
    }
}
