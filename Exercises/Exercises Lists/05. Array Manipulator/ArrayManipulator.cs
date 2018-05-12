using System;
using System.Collections.Generic;
using System.Linq;

class ArrayManipulator
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToList();

        while (true)
        {
            var comand = Console.ReadLine();
            if (comand == "print")
            {
                break;
            }
            var comandArgs = comand.Split(' ').ToList();

            var currentCommand = comandArgs[0];
            switch (currentCommand.ToLower())
            {
                case "add":
                    ManupulateAddComand(numbers, comandArgs);
                    break;
                case "contains":
                    ManupulateContainsComand(numbers, comandArgs);
                    break;
                case "addMany":
                    ManupulateAddMany(numbers, comandArgs); break;
                case "remove":
                    int indexToRemove = int.Parse(comandArgs[1]);
                    numbers.RemoveAt(indexToRemove);
                    break;
                case "shift":
                    ShiftingPosition(numbers, comandArgs);
                    break;
                case "sumPairs":
                    numbers = SumPairs(numbers);
                    break;
            }
        }
        Console.WriteLine("[" + string.Join(", ", numbers) + "]");

    }

    private static List<int> SumPairs(List<int> numbers)
    {
        var sumPairResult = new List<int>();
        for (int i = 1; i < numbers.Count; i += 2)
        {
            sumPairResult.Add(numbers[i] + numbers[i - 1]);
        }
        return sumPairResult;
    }

    private static void ShiftingPosition(List<int> numbers, List<string> comandArgs)
    {
        int postion = int.Parse(comandArgs[1]);
        var elementsToShift = numbers.Take(postion).ToList();
        var elements = numbers.Skip(postion).Take(numbers.Count - postion).ToList();
        numbers = elements.Concat(elementsToShift).ToList();

    }

    private static void ManupulateAddMany(List<int> numbers, List<string> comandArgs)
    {
        var numbersToInsert = new List<int>();
        for (int i = comandArgs.Count - 1; i >= 2; i--)
        {
            numbersToInsert.Add(int.Parse(comandArgs[i]));
        }
        int index = int.Parse(comandArgs[1]);
        for (int i = 0; i < numbersToInsert.Count; i++)
        {
            InsertNewElementsByIndex(index, numbersToInsert[i], numbers);
        }

    }

    private static void InsertNewElementsByIndex(int index, int element, List<int> numbers)
    {
        if (index < 0 || index > numbers.Count - 1)
        {
            return;
        }
        numbers.Insert(index, element);
    }

    private static void ManupulateContainsComand(List<int> numbers, List<string> comandArgs)
    {
        int searchedElement = int.Parse(comandArgs[1]);
        if (numbers.Contains(searchedElement))
        {
            Console.WriteLine(numbers.IndexOf(searchedElement));
        }
        else
        {
            Console.WriteLine("-1");
        }
    }

    private static void ManupulateAddComand(List<int> numbers, List<string> comandArgs)
    {

        int index = int.Parse(comandArgs[1]);
        int element = int.Parse(comandArgs[2]);
        if (index < 0 || index > numbers.Count)
        {
            return;
        }
        numbers.Insert(index, element);
    }
}


