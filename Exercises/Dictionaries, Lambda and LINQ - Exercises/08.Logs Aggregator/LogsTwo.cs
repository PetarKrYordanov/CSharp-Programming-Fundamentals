using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Logs_Aggregator
{
    class LogsTwo
    {
        static void Main()
        {
            int numberOfLogs = int.Parse(Console.ReadLine());
            string inputLine = Console.ReadLine();

            var userLogs = new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfLogs; i++)
            {
                var listOfInput = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string username = listOfInput[1];
                string ipAddres = listOfInput[0];
                int duration = int.Parse(listOfInput[2]);

                if (!userLogs.ContainsKey(username))
                {
                    userLogs[username] = new Dictionary<string, int>();
                }
                if (!userLogs[username].ContainsKey(ipAddres))
                {
                    userLogs[username][ipAddres] = duration;
                }
                else
                {
                    userLogs[username][ipAddres] += duration;
                }


                inputLine = Console.ReadLine();
            }
            foreach (var log in userLogs.OrderBy(x =>x.Key).ThenByDescending(x => x.Value.Keys))
            {
                List<string> listOfIpAddres = new List<string>();

                foreach (var item in log.Value)
                {
                    listOfIpAddres.Add(item.Key);
                }
                listOfIpAddres = listOfIpAddres.OrderBy(x => x).ToList();
                Console.WriteLine($"{log.Key}: {log.Value.Values.Sum()} [{string.Join(", ",listOfIpAddres)}]" );     
            }
        }
    }
}
