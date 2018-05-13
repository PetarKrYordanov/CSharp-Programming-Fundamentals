using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _08._Mentor_Group
{
    class MentorGroup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var students = new List<Student>();

            while (input != "end of dates")
            {
                var dateAndNames = input
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
                string name = dateAndNames[0];
                var result = new Dictionary<String, Student>();
                List<DateTime> dateList = new List<DateTime>();

                for (int i = 1; i < dateAndNames.Length; i++)
                {
                    DateTime currentDate = DateTime.ParseExact(dateAndNames[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dateList.Add(currentDate);
                }

                Student currentStudent = new Student();
                currentStudent.Name = name;
                currentStudent.AttendedDates = dateList;
                students.Add(currentStudent);

                input = Console.ReadLine();
            }
            while (input != "end of comments")
            {
                var nameAndComents = input
                    .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Student currentStudent = new Student();

                if (students.Any(x => x.Name == nameAndComents[0]))
                {
                    currentStudent = students.First(y => y.Name == nameAndComents[0]);

                    currentStudent.Comments = new List<string>();
                    currentStudent.Comments.Add(nameAndComents[1]);
                }
                input = Console.ReadLine();
            }
            foreach (var student in students.OrderBy(x => x.Name).ThenBy(y => y.AttendedDates))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                if (student.Comments != null)
                {
                    foreach (var comment in student.Comments)
                    {
                        Console.WriteLine("- " + comment);
                    }
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in student.AttendedDates.OrderBy(c => c))
                {
                    var dateAsString = date.ToString("dd/MM/yyyy");
                    Console.WriteLine("-- " + dateAsString);
                }
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<String> Comments { get; set; }
        public List<DateTime> AttendedDates { get; set; }

    }
}
