using System;


class PadawanEquipment
{
    static void Main(string[] args)
    {
        decimal amountOfMoney = decimal.Parse(Console.ReadLine());
        var countOfStudents = int.Parse(Console.ReadLine());
        var sabrePrice = decimal.Parse(Console.ReadLine());
        var robesPrice = decimal.Parse(Console.ReadLine());
        var beltPrice = decimal.Parse(Console.ReadLine());

        var numberOfSabre = Math.Ceiling(1.1 * countOfStudents);
        var freeBelts = countOfStudents / 6;

        int numberOfBelts = countOfStudents - freeBelts;
        decimal totalPrice = countOfStudents * robesPrice + (decimal)numberOfSabre * sabrePrice + numberOfBelts * beltPrice;

        if (totalPrice <= amountOfMoney)
        {
            Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivan Cho will need {(totalPrice - amountOfMoney):f2}lv more.");
        }
    }
}

