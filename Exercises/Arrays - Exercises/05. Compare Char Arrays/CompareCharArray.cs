using System;
using System.Linq;

namespace _05._Compare_Char_Arrays
{
    class CompareCharArray
    {
        static void Main()
        {
            char[] firstArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            char[] secondArray
                = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            int minLength = Math.Min(firstArray.Length, secondArray.Length);
            bool isFirst = false;

            for (int i = 0; i < minLength; i++)
            {
                if (firstArray != secondArray)
                {
                    if (firstArray[i] < secondArray[i])
                    {
                        isFirst = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (isFirst)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
            else
            {
                if (firstArray.Length < secondArray.Length)
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                }

                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }

        }
    }
}
