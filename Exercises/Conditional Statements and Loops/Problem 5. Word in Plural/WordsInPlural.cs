using System;

namespace Problem_5._Word_in_Plural
{
    class WordsInPlural
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string wordInPlural;

            string[] EndOfTheWord = { "o", "ch", "s", "sh", "x", "z" };

            foreach (string item in EndOfTheWord)
            {
                if (inputText.EndsWith(item))
                {
                    inputText = inputText + "es";
                    Console.WriteLine(inputText);
                    break;
                }
            }

            if (inputText.EndsWith("y"))
            {
                inputText = inputText.Substring(0, inputText.LastIndexOf("y"));
                inputText = inputText + "ies";
                Console.WriteLine(inputText);
            }
            else if (inputText.EndsWith("s"))
            {

            }
            else
            {
                inputText = inputText + "s";
                Console.WriteLine(inputText);

            }
        }
    }
}
