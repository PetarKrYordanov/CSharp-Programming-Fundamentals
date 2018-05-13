using System;

namespace Problem_2._Choose_a_Drink_2._0
{
    class ChooseDrink2
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            decimal price;

            switch (profession)
            {
                case "Athlete":
                    price = 0.7m;
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = 1m;
                    break;
                case "SoftUni Student":
                    price = 1.7m;
                    break;
                default:
                    price = 1.2m;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {price * quantity:f2}.");
        }
    }
}
