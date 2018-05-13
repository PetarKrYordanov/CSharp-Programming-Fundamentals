using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Circles_Intersection
{
    class CircleIntersection
    {
        static void Main(string[] args)
        {
            int[] firstCircleCord = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] secondCircleCord = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            Point firstPoint = new Point(firstCircleCord[0], firstCircleCord[1]);
            Point secondtoint = new Point(secondCircleCord[0], secondCircleCord[1]);

            Circle firstCircle = new Circle(firstPoint, firstCircleCord[2]);
            Circle secondCircle = new Circle(secondtoint, secondCircleCord[2]);

            if (Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
