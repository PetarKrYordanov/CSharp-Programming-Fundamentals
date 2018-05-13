using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Average_Grades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < studentCount; i++)
            {
                Student student = new Student();
                string[] studentInfo = Console.ReadLine().Split(' ');
                var studentName = studentInfo[0];

                student.Name = studentName;
                student.Grades = studentInfo.Skip(1).Select(double.Parse).ToList();

                students.Add(student);
            }

            students.Where(x => x.Average >= 5)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.Average)
                .ToList()
                .ForEach(x =>
                {
                    Console.WriteLine($"{x.Name} -> {x.Average:f2}");
                });
        }
    }
}
