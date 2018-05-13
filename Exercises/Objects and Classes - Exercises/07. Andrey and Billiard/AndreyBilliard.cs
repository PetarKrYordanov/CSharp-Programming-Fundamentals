using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Andrey_and_Billiard
{
    class AndreyBilliard
    {
        static void Main(string[] args)
        {
            int numberOfEntity = int.Parse(Console.ReadLine());
            string inputLine = Console.ReadLine();
            var menu = new Dictionary<string, decimal>();


            for (int i = 0; i < numberOfEntity; i++)
            {
                var inputEntity = inputLine
                   .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();
                string entity = inputEntity[0];
                decimal priceEntity = decimal.Parse(inputEntity[1]);

                if (!menu.ContainsKey(entity))
                {
                    menu.Add(entity, priceEntity);
                }
                else
                {
                    menu[entity] = priceEntity;
                }
                inputLine = Console.ReadLine();
            }

            var customerList = new List<Client>();

            while (inputLine != "end of clients")
            {
                var customerInput = inputLine
                    .Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                var customerName = customerInput[0];
                var entity = customerInput[1];
                var quantity = int.Parse(customerInput[2]);


                if (!menu.ContainsKey(entity))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
                decimal price = menu[entity];
                Client currentClent = new Client();
                if (customerList.Any(x => x.Name == customerName))
                {
                    currentClent = customerList.First(y => y.Name == customerName);

                    if (!currentClent.ShopList.ContainsKey(entity))
                    {
                        currentClent.ShopList.Add(entity, 0);
                    }
                    currentClent.ShopList[entity] += quantity;
                    currentClent.Bill += (quantity * price);
                }
                else
                {
                    currentClent.Name = customerName;
                    currentClent.ShopList = new Dictionary<string, int>();
                    currentClent.ShopList.Add(entity, 0);
                    currentClent.ShopList[entity] = quantity;
                    currentClent.Bill = quantity * price;
                    customerList.Add(currentClent);
                }



                inputLine = Console.ReadLine();
            }

            foreach (var Customer in customerList.OrderBy(x => x.Name))
            {
                Console.WriteLine(Customer.Name);
                foreach (var item in Customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {Customer.Bill:f2}");
            }

            decimal sum = customerList.Sum(x => x.Bill);
            Console.WriteLine($"Total bill: {sum:f2}");
        }
    }
    class Client
    {

        public string Name { get; set; }
        public Dictionary<String, int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }
}