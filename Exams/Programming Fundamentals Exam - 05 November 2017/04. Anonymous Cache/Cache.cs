using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Anonymous_Cache
{
    class Cache
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            List<string> dataSetList = new List<string>();

            var dictionaryData = new Dictionary<string, Dictionary<string, int>>();
            while (inputLine != "thetinggoesskrra")
            {
                List<string> inputAsList = new List<string>();
                inputAsList = inputLine.Split(new char[] { ' ', '|', '>', '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (inputAsList.Count == 1)
                {
                    if (!dictionaryData.ContainsKey(inputAsList[0]))
                    {
                        dictionaryData[inputAsList[0]] = new Dictionary<string, int>();
                    }
                    dataSetList.Add(inputLine);

                }
                else
                {
                    string dataKey = inputAsList[0];
                    string dataSet = inputAsList[2];
                    int dataSize = int.Parse(inputAsList[1]);

                    if (!dictionaryData.ContainsKey(dataSet))
                    {
                        dictionaryData[dataSet] = new Dictionary<string, int>();
                    }

                    if (!dictionaryData[dataSet].ContainsKey(dataKey))
                    {
                        dictionaryData[dataSet][dataKey] = dataSize;
                    }
                }

                inputLine = Console.ReadLine();
            }
            bool isEmpty = !dataSetList.Any();
            if (isEmpty)
            {
                return;
            }
            foreach (var item in dictionaryData.OrderByDescending(x => x.Value.Values.Sum()))
            {
                if (!dataSetList.Contains(item.Key))
                {
                    continue;
                }

                Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value.Values.Sum()}");

                foreach (var data in item.Value)
                {
                    Console.WriteLine($"$.{data.Key}");
                }
                return;
            }
        }
    }
}
