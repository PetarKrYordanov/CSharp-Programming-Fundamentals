using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double Average
    {
        get
        {
            return Grades.Average();
        }
    }
}