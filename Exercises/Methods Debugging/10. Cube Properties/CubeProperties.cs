using System;

namespace _10._Cube_Properties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            var cubeSide = double.Parse(Console.ReadLine());
            string propertyToCalc = Console.ReadLine();
            if (propertyToCalc == "face")
            {
                CalculateFace(cubeSide);
            }
            else if (propertyToCalc == "volume")
            {
                CalculateVolume(cubeSide);
            }
            else if (propertyToCalc == "space")
            {
                CalculateSpace(cubeSide);
            }
            else
            {
                CalculateArea(cubeSide);
            }

        }

        private static void CalculateArea(double cubeSide)
        {
            double area = 6 * cubeSide * cubeSide;
            Console.WriteLine($"{area:f2}");
        }

        private static void CalculateSpace(double cubeSide)
        {
            double space = cubeSide * Math.Sqrt(3);
            Console.WriteLine($"{space:f2}");
        }

        private static void CalculateVolume(double cubeSide)
        {
            double volume = Math.Pow(cubeSide, 3);
            Console.WriteLine($"{volume:f2}");
        }

        private static void CalculateFace(double cubeSide)
        {
            double faceCalc = Math.Sqrt(2) * cubeSide;
            Console.WriteLine($"{faceCalc:f2}");
        }
    }
}
