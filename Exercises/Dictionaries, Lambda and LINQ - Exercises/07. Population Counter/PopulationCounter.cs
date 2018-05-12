using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Population_Counter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            var countryPopulation = new SortedDictionary<string, Dictionary<string, long>>();

            while (inputLine != "report")
            {
               var inputLineAsList = inputLine.Split('|').ToList();
                var city = inputLineAsList[0];
                var country = inputLineAsList[1];
                long population = long.Parse(inputLineAsList[2]);

                if (!countryPopulation.ContainsKey(country))
                {
                    countryPopulation[country] = new Dictionary<string, long>();
                }

                if (!countryPopulation[country].ContainsKey(city))
                {
                    countryPopulation[country][city] = population;
                }
                else
                {
                    countryPopulation[country][city] += population;
                }
                inputLine = Console.ReadLine();
            }
            foreach (var country in countryPopulation.OrderByDescending(x =>x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
