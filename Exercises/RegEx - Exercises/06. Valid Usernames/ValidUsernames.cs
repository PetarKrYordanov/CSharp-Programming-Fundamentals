using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06._Valid_Usernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            var split = @"/\() ,";
            var inputUser = Console.ReadLine()
                .Split(split.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            var validUsers = new List<String>();
            var patterrn = @"([a-zA-Z][\w]{2,24})";

            foreach (var user in inputUser)
            {
                Match match = Regex.Match(user, patterrn);

                if (match.Success)
                {
                    if (match.Value.Length==user.Length)
                    {
                        validUsers.Add(user);
                    }
                }
            }

            var listLen = new List<int>();

            for (int i = 0; i < validUsers.Count-1; i++)
            {
                int sumLen = validUsers[i].Length + validUsers[i+1].Length;
                listLen.Add(sumLen);
            }

           int startIndex = listLen.IndexOf(listLen.Max());
            Console.WriteLine(validUsers[startIndex]);
            Console.WriteLine(validUsers[startIndex+1]);


        }
    }
}
