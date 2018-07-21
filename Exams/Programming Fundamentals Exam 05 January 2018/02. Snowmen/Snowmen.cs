using System;
using System.Collections.Generic;
using System.Linq;

class Snowmen
{
    static void Main()
    {
        var elements = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

        int target;
        var listOfLosers = new List<int>();
        var listOfWinners = new List<int>();

        while (true)
        {
            if (elements.Count == 1)
            {
                return;
            }

            for (int index = 0; index < elements.Count; index++)
            {

                if (listOfLosers.Contains(index))
                {
                    continue;
                }
                target = elements[index] % elements.Count;
                var difference = Math.Abs(index - target);

                if (difference == 0)
                {
                    //attackerElement makes harakiri

                    if (!listOfLosers.Contains(index))
                    {
                        listOfLosers.Add(index);
                    }
                    Console.WriteLine($"{index} performed harakiri");
                }
                else if (difference % 2 == 0)
                {
                    //attacker wins
                    listOfWinners.Add(index);
                    if (!listOfLosers.Contains(target))
                    {
                        listOfLosers.Add(target);
                    }

                    if (!listOfLosers.Contains(index))
                    {
                        Console.WriteLine($"{index} x {target} -> {index} wins");
                    }
                }
                else
                {
                    //target wins
                    if (!listOfLosers.Contains(index))
                    {
                        listOfLosers.Add(index);
                    }

                    Console.WriteLine($"{index} x {target} -> {target} wins");
                }

                if (listOfLosers.Count + 1 == elements.Count)
                {
                    return;
                }
            }

            for (int i = 0; i < listOfLosers.Count; i++)
            {
                elements[listOfLosers[i]] = -1;
            }

            while (elements.Contains(-1))
            {
                elements.Remove(-1);
            }
            listOfLosers.Clear();
            listOfWinners.Clear();
        }
    }
}