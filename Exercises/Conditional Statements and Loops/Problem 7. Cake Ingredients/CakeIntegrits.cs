using System;
using System.Collections.Generic;


namespace Problem_7._Cake_Ingredients
{
    class CakeIntegrits
    {
        static void Main(string[] args)
        {
            List<string> ingredients = new List<string>();
            int count = 0;

            for (int i = 0; i < 20; i++)
            {
                ingredients.Add(Console.ReadLine());
                if (ingredients[i] == "Bake!")
                {
                    break;
                }

                Console.WriteLine("Adding ingredient {0}.", ingredients[i]);

                count++;
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", count);
        }
    }
}
