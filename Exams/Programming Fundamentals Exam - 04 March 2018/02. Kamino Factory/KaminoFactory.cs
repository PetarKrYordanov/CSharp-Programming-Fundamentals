using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Kamino_Factory
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());

            List<DNA> samplesOfDNA = new List<DNA>();
            int count = 0;
            while (true)
            {
                count++;
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }

                List<int> DNAInput = input
                .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Take(length)
                .ToList();

                DNA currentDNA = MaxSequenceOFOnes(DNAInput, length);
                samplesOfDNA.Add(currentDNA);
            }
            DNA bestDNA = samplesOfDNA.OrderByDescending(x => x.BestLength)
                .ThenBy(x => x.Start)
                .ThenByDescending(x => x.Sum)
                .First();

            Console.WriteLine($"Best DNA sample {samplesOfDNA.IndexOf(bestDNA) + 1} with sum: {bestDNA.Sum}.");
            Console.WriteLine(string.Join(" ", bestDNA.Name));
        }

        private static DNA MaxSequenceOFOnes(List<int> dNAInput, int lenghtOfDNA)
        {
            int start = 0;
            int length = 0;
            int bestLength = 0;
            int bestStart = int.MinValue;
            int sum = 0;
            for (int i = 0; i < lenghtOfDNA; i++)
            {
                sum += dNAInput[i];

                if (dNAInput[i] == 1)
                {
                    length++;
                }
                else
                {
                    length = 0;
                    start = i;
                }
                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }
            DNA dna = new DNA();
            dna.Name = dNAInput;
            dna.BestLength = bestLength;
            dna.Start = bestStart;
            dna.Sum = sum;

            return dna;
        }
    }
    class DNA
    {
        public List<int> Name { get; set; }
        public int Start { get; set; }
        public int Sum { get; set; }
        public int BestLength { get; set; }
    }
}
