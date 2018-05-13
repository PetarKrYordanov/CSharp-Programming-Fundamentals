using System;

namespace Problem_11._5_Different_Numbers
{
    class DifferentNumbers
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                for (int j = startNumber; j < endNumber; j++)
                {
                    for (int k = startNumber; k < endNumber; k++)
                    {
                        for (int l = startNumber; l < endNumber; l++)
                        {
                            for (int m = startNumber; m <= endNumber; m++)
                            {
                                if (startNumber <= i && i < j && j < k && k < l && l < m && m <= endNumber)
                                {
                                    count++;

                                    Console.WriteLine("{0} {1} {2} {3} {4} ", i, j, k, l, m);
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
