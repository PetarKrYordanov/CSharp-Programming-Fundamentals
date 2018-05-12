using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

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
                inputLine = Console.ReadLine();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

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
                inputLine = Console.ReadLine();
            }
        }
    }
}
