using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


class StudentGroups
{
    static void Main(string[] args)
    {
        var townList = new List<Town>();
        townList = ReadTownsAndStudents();
        var groupList = new List<Group>();
        groupList = DistributeStudentsIntoGroups(townList);

        Console.WriteLine($"Created {groupList.Count} groups in {townList.Count} towns:");

        foreach (var group in groupList)
        {
            var currentTown = group.Town.Name;
            List<string> emailList = new List<string>();

            foreach (var student in group.Students)
            {
                emailList.Add(student.Email);
            }
            Console.WriteLine($"{currentTown} => {string.Join(", ", emailList)}");
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }
    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
    private static List<Group> DistributeStudentsIntoGroups(List<Town> townList)
    {
        var groups = new List<Group>();
        foreach (var town in townList.OrderBy(x => x.Name))
        {
            IEnumerable<Student> students = town.Students
                .OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email);

            while (students.Any())
            {
                var group = new Group();
                group.Town = town;
                group.Students = students.Take(group.Town.SeatsCount).ToList();
                students = students.Skip(group.Town.SeatsCount);

                groups.Add(group);
            }
        }
        return groups;
    }
    static List<Town> ReadTownsAndStudents()
    {
        var inputLine = Console.ReadLine();
        var towns = new List<Town>();
        while (inputLine != "End")
        {
            if (inputLine.Contains("=>"))
            {
                Town town = new Town();
                var townProperty = inputLine.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                town.Name = townProperty[0].Trim();
                town.SeatsCount = int.Parse(townProperty[1].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First());

                town.Students = new List<Student>();
                towns.Add(town);
            }
            else
            {
                var studentProperty = inputLine
                    .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Student student = new Student();
                student.Name = studentProperty[0];
                student.Email = studentProperty[1].Trim();
                student.RegistrationDate = DateTime
                    .ParseExact(studentProperty[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                towns.Last().Students.Add(student);
            }
            inputLine = Console.ReadLine();
        }
        return towns;
    }
}