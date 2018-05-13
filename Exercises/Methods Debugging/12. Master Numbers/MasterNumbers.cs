using System;
using System.Collections.Generic;

namespace _12._Master_Numbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string sadas = n.ToString();

            for (int currentNumber = 1; currentNumber <= n; currentNumber++)
            {
                List<int> digitsOfN = TakingDigitsOfn(currentNumber);
                bool isSymetric = isPalindrome(digitsOfN);

                if (isSymetric == false)
                {
                    continue;
                }

                bool someOfDigitDivSeven = someOfDigit(digitsOfN);

                if (someOfDigitDivSeven == false)
                {
                    continue;
                }

                bool containEvenDigit = ContainEvenDigit(digitsOfN);

                if (containEvenDigit == false)
                {
                    continue;
                }

                if (isSymetric && someOfDigitDivSeven && containEvenDigit)
                {
                    Console.WriteLine(currentNumber);
                }
            }
        }

        private static bool ContainEvenDigit(List<int> digitsInN)
        {
            for (int i = 0; i <= digitsInN.Count - 1; i++)
            {
                if (digitsInN[i] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static bool someOfDigit(List<int> numbersOfN)
        {
            int sum = 0;

            for (int i = 0; i <= numbersOfN.Count - 1; i++)
            {
                sum += numbersOfN[i];
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static List<int> TakingDigitsOfn(int n)
        {
            var numbersOfN = new List<int>();

            while (n > 0)
            {
                int lastNumber = n % 10;
                numbersOfN.Add(lastNumber);
                n /= 10;
            }
            return numbersOfN;
        }

        static bool isPalindrome(List<int> numbersOfN)
        {
            for (int i = 0; i <= numbersOfN.Count - 1; i++)
            {
                if (numbersOfN[i] != numbersOfN[numbersOfN.Count - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
