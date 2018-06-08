using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01._Snowballs
{
    class Snowballs
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            var values = new List<ulong>();
            var output = new List<string>();

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                var snowballQuality = int.Parse(Console.ReadLine());

                ulong snowballValue = (ulong)Math.Pow(snowballSnow / snowballTime, snowballQuality);
                values.Add(snowballValue);
                output.Add($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");
            }
            int max = values.IndexOf(values.Max());
            Console.WriteLine(output[max]);
        }
    }
}
