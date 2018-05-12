using System;
using System.Numerics;

namespace _02._Convert_from_base_N_to_base_10
{
    class ConverTo10base
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string num = input[1];
            var numBase = long.Parse(input[0]);
            int charInNum;

            BigInteger pow = 1;
            BigInteger res = 0;
            BigInteger result = 0;


            for (int i = num.Length - 1; i >= 0; i--)
            {
                charInNum = num[i] - '0';

                if (i == num.Length - 1)
                {
                    pow = 1;
                }
                else
                {
                    pow *= numBase;
                }
                res = pow * charInNum;
                result += res;
            }

            Console.WriteLine(result);
        }
    }
}
