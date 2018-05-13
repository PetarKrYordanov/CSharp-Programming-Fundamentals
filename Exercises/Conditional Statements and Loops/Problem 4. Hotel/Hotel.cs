using System;

namespace Problem_4._Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            int numOfNights = int.Parse(Console.ReadLine());

            double priceStudio;
            double priceDouble;
            double priceSuite;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceDouble = 65;
                    priceSuite = 75;
                    if (numOfNights > 7)
                    {
                        priceStudio *= 0.95;
                    }
                    break;
                case "June":
                case "September":
                    priceStudio = 60;
                    priceDouble = 72;
                    priceSuite = 82;
                    if (numOfNights > 14)
                    {
                        priceDouble = 0.9 * priceDouble;
                    }
                    break;
                default:
                    priceStudio = 68;
                    priceDouble = 77;
                    priceSuite = 89;

                    if (numOfNights > 14)
                    {
                        priceSuite = 0.85 * priceSuite;
                    }
                    break;
            }

            double totalDouble = numOfNights * priceDouble;
            double totalSuite = numOfNights * priceSuite;

            if ((month == "September" || month == "October")
                && numOfNights > 7)
            {
                numOfNights -= 1;
            }
            double totalStudio = numOfNights * priceStudio;

            Console.WriteLine($"Studio: {totalStudio:f2} lv.");
            Console.WriteLine($"Double: {totalDouble:f2} lv.");
            Console.WriteLine($"Suite: {totalSuite:f2} lv.");
        }
    }
}
