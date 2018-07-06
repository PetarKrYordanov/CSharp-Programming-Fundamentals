namespace _04.SoftUniExamResults
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var personPoints = new Dictionary<string, int>();
            var submissionsCount = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (input != "exam finished")
            {
                var submissionArg = input.Split('-', StringSplitOptions.RemoveEmptyEntries).ToList();
                var person = submissionArg[0];
                if (submissionArg[1] =="banned")
                {
                    if (personPoints.ContainsKey(person))
                    {
                        personPoints.Remove(person);
                    }
                    input = Console.ReadLine();
                    continue;
                }

                var language = submissionArg[1];
                var points = int.Parse(submissionArg[2]);

                if (submissionsCount.ContainsKey(language))
                {
                    submissionsCount[language]++;
                }
                else
                {
                    submissionsCount.Add(language, 1);
                }

                if (personPoints.ContainsKey(person))
                {
                    int currentPoints = personPoints[person];
                    if (currentPoints < points)
                    {
                        personPoints[person] = points;
                    }            
                }
                else
                {
                    personPoints.Add(person, points);
                }
                input = Console.ReadLine();
            }
            PrintResult(personPoints, submissionsCount);
        }

        private static void PrintResult(Dictionary<string, int> personPoints, Dictionary<string, int> submissionsCount)
        {
            Console.WriteLine("Results:");
            foreach (var result in personPoints.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{result.Key} | {result.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var languageCount in submissionsCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{languageCount.Key} - {languageCount.Value}");
            }
        }
    }
}
