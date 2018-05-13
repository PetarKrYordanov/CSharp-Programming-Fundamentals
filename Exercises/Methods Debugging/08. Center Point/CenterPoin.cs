using System;

namespace _08._Center_Point
{
    class CenterPoin
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            double pointOneDistance = CalculateDistance(x1, y1);
            double pointTwoDistance = CalculateDistance(x2, y2);

            if (pointOneDistance > pointTwoDistance)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }

        private static double CalculateDistance(double x, double y)
        {
            double squareX = Math.Pow(x, 2);
            double squareY = Math.Pow(y, 2);

            var sum = squareY + squareX;
            double distance = Math.Sqrt(sum);

            return distance;
        }
    }
}
