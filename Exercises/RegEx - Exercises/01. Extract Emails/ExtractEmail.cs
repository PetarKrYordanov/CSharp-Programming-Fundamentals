﻿using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Emails
{
    class ExtractEmail
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(^|?<=\s)[a-z0-9]+([-_.]*[a-z0-9])*@[a-z0-9]+([.\-]+[a-z0-9]+)+";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }

        }
    }
}
