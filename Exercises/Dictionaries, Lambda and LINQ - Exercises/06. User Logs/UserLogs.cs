using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._User_Logs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            var userLogs = new SortedDictionary<string, Dictionary<string, int>>();

            while (inputLine != "end")
            {
                var inputLineAsList = inputLine
                    .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var ip = inputLineAsList[1];
                var username = inputLineAsList[inputLineAsList.Count - 1];

                if (!userLogs.ContainsKey(username))
                {
                    userLogs[username] = new Dictionary<string, int>();
                }

                if (!userLogs[username].ContainsKey(ip))
                {
                    userLogs[username][ip] = 1;
                }
                else
                {
                    userLogs[username][ip]++;
                }
                inputLine = Console.ReadLine();
            }
            foreach (var user in userLogs)
            {
                Console.WriteLine(user.Key +":");

                var ipPrint = user.Value.Keys.ToList();
                var occurances = user.Value.Values.ToList();

                Console.Write(string.Join(", ", user.Value.Select(x => x.Key + " => " + x.Value)));
                Console.WriteLine(".");
            }
        }
    }
}
