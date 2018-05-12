using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
{
    class ChangeList
    {
        static void Main()
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string comandLine = Console.ReadLine();

            while (comandLine != "Odd" && comandLine != "Even")
            {
                string[] comandArgs = comandLine
                    .Split(' ')
                    .ToArray();
                if (comandArgs[0] == "Delete")
                {
                    int numberToDelete = int.Parse(comandArgs[1]);

                    while (inputNumbers.Contains(numberToDelete))
                    {
                        inputNumbers.Remove(numberToDelete);
                    }
                }
                else if (comandArgs[0] == "Insert")
                {
                    int element = int.Parse(comandArgs[1]);
                    int index = int.Parse(comandArgs[2]);
                    inputNumbers.Insert(index, element);
                }
                comandLine = Console.ReadLine();
            }
            if (comandLine == "Odd")
            {
                foreach (var element in inputNumbers)
                {
                    if (element % 2 != 0)
                    {
                        Console.Write(element + " ");
                    }
                }
            }
            else
            {
                foreach (var element in inputNumbers)
                {
                    if (element % 2 == 0)
                    {
                        Console.Write(element + " ");
                    }
                }
            }
        }
    }
}
