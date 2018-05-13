using System;

namespace _1._Hello__Name_
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string enteredName = Console.ReadLine();
            GreetingByName(enteredName);

        }
        private static void GreetingByName(String name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
