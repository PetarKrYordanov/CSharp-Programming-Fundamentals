using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Force_Book
{
    class ForceBook
    {
        static void Main(string[] args)
        {
            var forceSides = new Dictionary<string, List<string>>();

            var sideUserPattern = @"(.+?)( \| )(.+)";
            Regex sideUserRegex = new Regex(sideUserPattern);

            var userSidePattern = @"(.+?)( \-> )(.+)";
            Regex userSideRegex = new Regex(userSidePattern);

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }
                var user = "";
                var side = "";

                if (sideUserRegex.IsMatch(input))
                {
                    Match match = sideUserRegex.Match(input);
                    user = match.Groups[3].Value;
                    side = match.Groups[1].Value;
                    AddSideUserToDictionary(side, user, forceSides);
                    continue;
                }

                if (userSideRegex.IsMatch(input))
                {
                    Match match = userSideRegex.Match(input);
                    user = match.Groups[1].Value;
                    side = match.Groups[3].Value;
                    AddUserSideToDictionary(user, side, forceSides);
                }
            }
            foreach (var item in forceSides.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");

                foreach (var user in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine("! " + user);
                }
            }
        }

        private static void AddUserSideToDictionary(string user, string side, Dictionary<string, List<string>> forceSides)
        {
            var strings = forceSides.Where(kvp => kvp.Value.Contains(user))
                              .Select(kvp => kvp.Key).ToList();
            if (strings.Count != 0)
            {
                var thisSide = strings[0];
                forceSides[thisSide].Remove(user);

                if (forceSides[thisSide].Count == 0)
                {
                    forceSides.Remove(thisSide);
                }

                if (!forceSides.ContainsKey(side))
                {
                    List<string> users = new List<string>();
                    users.Add(user);
                    forceSides.Add(side, users);
                }
                else
                {
                    forceSides[side].Add(user);
                }

                Console.WriteLine($"{user} joins the {side} side!");
            }
            else
            {
                if (!forceSides.ContainsKey(side))
                {
                    List<string> users = new List<string>();
                    users.Add(user);
                    forceSides.Add(side, users);
                }
                else
                {
                    forceSides[side].Add(user);
                }

                Console.WriteLine($"{user} joins the {side} side!");
            }
        }

        private static void AddSideUserToDictionary(string side, string user, Dictionary<string, List<string>> forceSides)
        {
            var strings = forceSides.Where(kvp => kvp.Value.Contains(user))
                             .Select(kvp => kvp.Key).ToList();

            if (strings.Count != 0)
            {
                return;
            }
            else
            {
                if (!forceSides.ContainsKey(side))
                {
                    List<string> users = new List<string>();
                    users.Add(user);
                    forceSides.Add(side, users);
                }
                else
                {
                    forceSides[side].Add(user);
                }
                //  Console.WriteLine($"{user} joins the {side} side!");
            }
        }
    }
}
