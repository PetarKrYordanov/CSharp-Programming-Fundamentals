using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var attacked = new List<string>();
            var destroyed = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var message = Console.ReadLine();

                int decryptNumber = NumberOfStars(message);

                string dectyptedMessage = DecryptMesage(message, decryptNumber);

                ProcessMessages(dectyptedMessage, attacked, destroyed);
            }
            PrintResult(attacked, destroyed);
        }

        private static void PrintResult(List<string> attacked, List<string> destroyed)
        {
            Console.WriteLine($"Attacked planets: {attacked.Count}");

            if (attacked.Count > 0)
            {
                Console.Write("-> ");
                Console.WriteLine(string.Join("\n-> ", attacked.OrderBy(x => x)));
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");

            if (destroyed.Count > 0)
            {
                Console.Write("-> ");
                Console.WriteLine(string.Join("\n-> ", destroyed.OrderBy(x => x)));
            }
        }

        private static void ProcessMessages(string dectyptedMesage, List<string> attacked, List<string> destroyed)
        {
            bool isValid = false;

            var validatePattern = @"@([a-zA-Z]+)(([^@\:\>\!\?\-])*)+:([0-9]+)(([^@\:\>\!\?\-])*)+!([A|D])!(([^@\:\>\!\?\-])*)?->([0-9]+)";
            Regex regex = new Regex(validatePattern);

            if (!regex.IsMatch(dectyptedMesage))
            {
                return;
            }
            Match match = regex.Match(dectyptedMesage);

            if (match.Groups[7].Value == "D")
            {
                destroyed.Add(match.Groups[1].Value);
                return;
            }

            if (match.Groups[7].Value == "A")
            {
                attacked.Add(match.Groups[1].Value);
            }
        }

        private static string DecryptMesage(string message, int decryptNumber)
        {
            string decryptMessage = "";

            for (int i = 0; i < message.Length; i++)
            {
                int charIndes = message[i] - decryptNumber;
                decryptMessage += (char)charIndes;
            }
            return decryptMessage;
        }

        private static int NumberOfStars(string message)
        {
            int matchesCount = 0;

            var starPattern = @"([starSTAR])";
            Regex regex = new Regex(starPattern);

            if (regex.IsMatch(message))
            {
                MatchCollection matches = regex.Matches(message);
                foreach (Match item in matches)
                {
                    matchesCount++;
                }
            }
            return matchesCount;
        }
    }
}
