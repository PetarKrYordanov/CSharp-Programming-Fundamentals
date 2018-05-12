using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Phonebook_Upgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();

            var inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                var inputComand = inputLine.Split(' ').ToArray();

                if (inputComand[0] == "A")
                {

                    if (phonebook.ContainsKey(inputComand[1]))
                    {
                        phonebook[inputComand[1]] = inputComand[2];
                    }
                    else
                    {
                        phonebook.Add(inputComand[1], inputComand[2]);
                    }
                }
                else if (inputComand[0] == "S")
                {

                    if (phonebook.ContainsKey(inputComand[1]))
                    {
                        Console.WriteLine($"{inputComand[1]} -> {phonebook[inputComand[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {inputComand[1]} does not exist.");
                    }
                }
                else if (inputComand[0] == "ListAll")
                {

                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }
                inputLine = Console.ReadLine();
            }
        }
    }
}