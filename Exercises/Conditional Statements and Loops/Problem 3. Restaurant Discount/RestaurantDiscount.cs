using System;

namespace Problem_3._Restaurant_Discount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            var hallPrice = 0;
            string hallSize;

            if (groupSize <= 50)
            {
                hallPrice = 2500;
                hallSize = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                hallPrice = 5000;
                hallSize = "Terrace";
            }
            else if (groupSize <= 120)
            {
                hallSize = "Great Hall";
                hallPrice = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            double discount;
            int pricePackage;

            switch (package)
            {
                case "Normal":
                    discount = 0.05;
                    pricePackage = 500; break;
                case "Gold":
                    discount = 0.1;
                    pricePackage = 750; break;
                default:
                    discount = 0.15;
                    pricePackage = 1000;
                    break;
            }
            double priceWithDiscount = (1 - discount) * (pricePackage + hallPrice);
            double pricePerPerson = priceWithDiscount / groupSize;

            Console.WriteLine($"We can offer you the {hallSize}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");


        }
    }
}
