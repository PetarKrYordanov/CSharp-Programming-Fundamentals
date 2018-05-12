using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01._Convert_from_base_10_to_base_N
{
    class ConvertToNBase
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            BigInteger decNum = BigInteger.Parse(input[1]);
            var numsBase = long.Parse(input[0]);
            BigInteger rem;

            List<BigInteger> result = new List<BigInteger>();

            while (decNum != 0)
            {
                rem = decNum % numsBase;
                result.Add(rem);
                decNum /= numsBase;
            }

            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
