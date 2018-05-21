using System;

namespace _01._PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            var pokePowerN = int.Parse(Console.ReadLine());
            var distanceM = int.Parse(Console.ReadLine());
            var exhaustionFactorY = int.Parse(Console.ReadLine());

            long count = 0;
            long powerN50percent = pokePowerN / 2;

            while (pokePowerN >= distanceM)
            {
                if (powerN50percent == pokePowerN && exhaustionFactorY != 0)
                {
                    pokePowerN = pokePowerN / exhaustionFactorY;
                    continue;
                }
                pokePowerN -= distanceM;

                count++;
            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(count);
        }
    }
}
