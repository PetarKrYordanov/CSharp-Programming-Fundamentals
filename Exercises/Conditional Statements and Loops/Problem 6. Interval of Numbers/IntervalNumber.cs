﻿using System;

namespace Problem_6._Interval_of_Numbers
{
    class IntervalNumber
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (n >= m)
            {
                for (int i = m; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = n; i <= m; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
