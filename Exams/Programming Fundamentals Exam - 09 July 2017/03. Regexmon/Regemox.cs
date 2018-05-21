using System;
using System.Text.RegularExpressions;

namespace _03._Regexmon
{
    class Regemox
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var didimonPattern = @"[^a-zA-Z-]+";
            var bojomonPattern = @"[a-zA-Z]+-[a-zA-Z]+";
            int round = 1;

            while (true)
            {
                if (round % 2 == 1)
                {
                    if (!Regex.IsMatch(input, didimonPattern))
                    {
                        return;
                    }
                    else
                    {
                        Match current = Regex.Match(input, didimonPattern);
                        input = input.Substring(current.Index + current.Length);

                        Console.WriteLine(current.ToString());
                    }
                }
                else
                {
                    if (!Regex.IsMatch(input, bojomonPattern))
                    {
                        return;
                    }
                    else
                    {
                        Match current = Regex.Match(input, bojomonPattern);
                        input = input.Substring(current.Index + current.Length);

                        Console.WriteLine(current.ToString());
                    }
                }
                round++;
            }
        }
    }
}
