using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char searchSymbol = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == searchSymbol)
            {
                hasMatch = true;

                int endIndex = jump + i;

                if (jump + i >= text.Length - 1)
                {
                    jump = text.Length - i - 1;

                }

                string matchedString = text.Substring(i, jump + 1);
                Console.WriteLine(matchedString);

                i += jump - 1;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
