namespace _03.SoftUniBarIncome
{
    using System;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string pattern = @"%([A-Z][a-z]+)%[^\|\$\%\.]*?<([\w]+)>[^\|\$\%\.]*?\|([\d]+)\|[^\|\$\%\.]*?([0-9]+(.[0-9]+)*)\$";

            var totalIncome = 0m;

            while (input != "end of shift")
            {
                var regex = new Regex(pattern);

                if (Regex.IsMatch(input, pattern))
                {
                    var match = regex.Match(input);

                    var customer = match.Groups[1];
                    var stock = match.Groups[2];

                    var quantity = int.Parse(match.Groups[3].ToString());
                    var price = decimal.Parse(match.Groups[4].ToString());
                    var spendMoney = price * quantity;

                    Console.WriteLine($"{customer}: {stock} - {spendMoney:F2}");

                    totalIncome += spendMoney;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
