using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fix_Emails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            var emails = new List<string>();

            string inputLine = Console.ReadLine();
            int counter = 0;

            while (inputLine != "stop")
            {
                if (counter % 2 == 0)
                {
                    names.Add(inputLine);
                }
                else
                {
                    if (inputLine.ToLower().EndsWith("us") 
                        || inputLine.ToLower().EndsWith("uK"))
                    {
                        int lastIndex = names.Count - 1;
                       names.RemoveAt(lastIndex);
                    }
                    else
                    {
                        emails.Add(inputLine);
                    }
                }
                counter++;

                inputLine = Console.ReadLine();
            }

            Dictionary<string, string> dictionary = CreateDictionary(names, emails);

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        private static Dictionary<string, string> CreateDictionary(List<string> nameList, List<string> emails)
        {
            var dict = new Dictionary<string, string>();

            for (int i = 0; i < emails.Count; i++)
            {

                if (dict.ContainsKey(nameList[i]))
                {
                    dict[nameList[i]] = emails[i];
                }
                else
                {
                    dict.Add(nameList[i], emails[i]);
                }
            }
            return dict;
        }

    }
}
