using System;

namespace _09._Index_of_Letters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] allphabet = new char[26];
            int indexCounter = 0;

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                allphabet[indexCounter] = letter;
                indexCounter++;
            }

            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];

                for (int j = 0; j < allphabet.Length; j++)
                {
                    if (currentLetter == allphabet[j])
                    {
                        Console.WriteLine($"{currentLetter} -> {j}");
                    }
                }
            }
        }
    }
}
