using System;
using System.Collections.Generic;
using System.Text;


class Circle
{
    public Point Center { get; set; }
    public int Radius { get; set; }

    public Circle(Point center, int radius)
    {
        Center = center;
        Radius = radius;
    }

    public static bool Intersect(Circle c1, Circle c2)
    {
        int d = (int)Point.CalculateDistance(c1.Center, c2.Center);

        if ((int)d <= c1.Radius + c2.Radius)
        {
            return true;
        }
        return false;
    }
}
