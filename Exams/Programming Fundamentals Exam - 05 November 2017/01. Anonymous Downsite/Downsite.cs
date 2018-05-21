using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace _01._Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int websiteCount = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            decimal totalLoss = 0m;
            for (int i = 0; i < websiteCount; i++)
            {
                string websiteData = Console.ReadLine();

                string[] dataArray = websiteData.Split(' ').ToArray();
                Console.WriteLine(dataArray[0]);

                totalLoss += (decimal.Parse(dataArray[1]) * decimal.Parse(dataArray[2]));


            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            BigInteger securityToken = securityKey;
            while (websiteCount-->1)
            {
                securityToken *= securityKey;
            }
            Console.WriteLine($"Security Token: {securityToken}");

        }
    }
}
