using System;

namespace _11._Geometry_Calculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                CalculateArea(side, height, 2);
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());

                CalculateArea(side, side, 1);
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                CalculateArea(width, height, 1);
            }
            else
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine($"{area:f2}");
            }
        }

        private static void CalculateArea(double side, double height, int v)
        {
            double area = side * height / v;

            Console.WriteLine($"{area:f2}");
        }
    }
}
