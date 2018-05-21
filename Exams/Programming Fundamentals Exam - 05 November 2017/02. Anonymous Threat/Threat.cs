using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Anonymous_Threat
{
    class Threat
    {
        static void Main(string[] args)
        {
            List<string> inputData = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string comandInput = Console.ReadLine();
            List<string> result = new List<string>();

            while (comandInput != "3:1")
            {
                List<string> comandList = comandInput
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (comandList[0] == "merge")
                {
                    result = MergeManupulation(comandList, inputData);
                }
                else if (comandList[0] == "divide")
                {
                    result = DivideManupulation(comandList, inputData);
                }

                inputData = result;
                comandInput = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", inputData));
        }

        private static List<string> DivideManupulation(List<string> comandList, List<string> inputData)
        {
            List<string> result = new List<string>();

            int divideIndex = int.Parse(comandList[1]);
            int patiotions = int.Parse(comandList[2]);

            for (int i = 0; i < divideIndex; i++)
            {
                result.Add(inputData[i]);
            }
            string divideString = inputData[divideIndex];
            string stringToAdd = string.Empty;
            int currentPartitions = 1;
            for (int i = 0; i < divideString.Length; i++)
            {
                int lengthOfSubstring = divideString.Length / patiotions;

                if (currentPartitions  == patiotions)
                {
                    stringToAdd = divideString.Substring(i);
                    result.Add(stringToAdd);
                    break;
                }
                if ((i+1) % lengthOfSubstring != 0 )
                {
                    stringToAdd += divideString[i];
                }
                else
                {
                    stringToAdd += divideString[i];
                    result.Add(stringToAdd);
                    stringToAdd = "";
                    currentPartitions++;
                }
            }
            for (int i = divideIndex+1; i < inputData.Count; i++)
            {
                result.Add(inputData[i]);
            }
            return result;
        }

        private static List<string> MergeManupulation(List<string> comandList, List<string> inputData)
        {
            int startIndex = int.Parse(comandList[1]);
            int endIndex = int.Parse(comandList[2]);

            List<string> result = new List<string>();
            string mergedString = string.Empty;

            if (startIndex > inputData.Count || endIndex < 0)
            {
                return inputData;
            }

            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex > inputData.Count - 1)
            {
                endIndex = inputData.Count - 1;
            }
            for (int i = 0; i < inputData.Count; i++)
            {
                if (i < startIndex)
                {
                    result.Add(inputData[i]);
                }
                else if (i <= endIndex)
                {
                    mergedString += inputData[i];

                    if (i == endIndex)
                    {
                        result.Add(mergedString);
                    }
                }
                else
                {
                    result.Add(inputData[i]);
                }
            }
            return result;
        }
    }
}
