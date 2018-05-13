using System;

namespace _03._English_Name_of_Last_Digit
{
    class NameLastDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int lastDigit = number % 10;

            string lastDigitAsString = lastDigitName(lastDigit);

            Console.WriteLine(lastDigitAsString);
        }

        private static string lastDigitName(int lastDigit)
        {
            string result = "";

            switch (lastDigit)
            {
                case 1: result = "one"; break;
                case 2: result = "two"; break;
                case 3: result = "three"; break;
                case 4: result = "four"; break;
                case 5: result = "five"; break;
                case 6: result = "six"; break;
                case 7: result = "seven"; break;
                case 8: result = "eight"; break;
                case 9: result = "nine"; break;
                case 0: result = "zero"; break;
                default:
                    Console.WriteLine("");
                    break;
            }
            return result;
        }
    }
}
