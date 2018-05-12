using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._A_Miner_Task
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            var resourceList = new List<string>();
            var resourceQuantity = new List<int>();

            string inputLine = Console.ReadLine();
            int counter = 0;

            while (inputLine != "stop")
            {
                if (counter % 2 == 0)
                {
                    resourceList.Add(inputLine);
                }
                else
                {
                    resourceQuantity.Add(int.Parse(inputLine));
                }

                counter++;
                inputLine = Console.ReadLine();
            }

            Dictionary<string, int> dictionary = CreateDictionary(resourceList, resourceQuantity);

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        private static Dictionary<string, int> CreateDictionary(List<string> resourceList, List<int> resourceQuantity)
        {
            var dict = new Dictionary<string, int>();

            for (int i = 0; i < resourceList.Count; i++)
            {
                if (dict.ContainsKey(resourceList[i]))
                {
                    dict[resourceList[i]] += resourceQuantity[i];
                }
                else
                {
                    dict.Add(resourceList[i], resourceQuantity[i]);
                }
            }
            return dict;
        }
    }
}
