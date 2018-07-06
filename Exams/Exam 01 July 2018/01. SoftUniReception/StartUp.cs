using System;

namespace _01._SoftUniReception
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var employeeOneHelpedStudentsPerHour = int.Parse(Console.ReadLine());
            var employeeTwoHelpedStudentsPerHour = int.Parse(Console.ReadLine());
            var employeeThreeHelpedStudentsPerHour = int.Parse(Console.ReadLine());

            int totalStudents = int.Parse(Console.ReadLine());

            var servicedForHourStudents = employeeOneHelpedStudentsPerHour + employeeTwoHelpedStudentsPerHour + employeeThreeHelpedStudentsPerHour;

            int hoursNeededForWork = 0;
            int hoursNeededForRest = 0;
            while (totalStudents > 0)
            {
                hoursNeededForWork++;
                totalStudents -= servicedForHourStudents;

                if (hoursNeededForWork % 3 == 0 && totalStudents > 0)
                {
                    hoursNeededForRest++;
                }
            }

            Console.WriteLine($"Time needed: {hoursNeededForWork + hoursNeededForRest}h.");

        }
    }
}
