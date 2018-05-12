using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;


namespace _06._Sum_big_numbers
{
    class SumBig
    {
        static void Main(string[] args)
        {
            var firstNum = Console.ReadLine().TrimStart('0').ToCharArray().Select(s => ((int)s - '0')).ToArray();
            var secondNum = Console.ReadLine().TrimStart('0').ToCharArray().Select(s => (int)s - '0').ToArray();
            var result = "";

            Array.Reverse(firstNum);
            Array.Reverse(secondNum);

            int minLength = Math.Min(firstNum.Length, secondNum.Length);
            int maxLength = Math.Max(firstNum.Length, secondNum.Length);
            int remainder = 0;

            for (int i = 0; i < minLength; i++)
            {
                int currentDigit = 0;
      
                int sum = firstNum[i] + secondNum[i] + remainder;

                if (sum>9)
                {
                    currentDigit = sum % 10;
                    remainder = sum / 10;
                }
                else
                {
                    currentDigit = sum;
                    remainder = 0;
                }

                result += currentDigit;
            }

            if (minLength!= maxLength)
            {
                if (firstNum.Length>secondNum.Length)
                {
                    result += MaxSum(firstNum, remainder, minLength, maxLength);
                }
                else
                {
                    result += MaxSum(secondNum, remainder, minLength, maxLength);
                }
            }

            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
        static string MaxSum(int[] nums,int rem, int minLen, int maxlen)
        {
            var result = "";
            int currentDigit;
            int sum;
            
            for (int i = minLen; i < maxlen; i++)
            {
                sum = nums[i] + rem;
                currentDigit = sum % 10;
                rem = sum / 10;
                result += currentDigit;
            }

            if (rem != 0)
            {
                result += rem;
            }

            return result;
        }
    }
   
}
