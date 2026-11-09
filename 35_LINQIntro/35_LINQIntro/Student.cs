using System;
using System.Collections.Generic;
using System.Text;

namespace _35_LINQIntro
{
    internal class Student
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public override string ToString() => $"Студент: {Name}, баллы: {Points};";
        public Student(string name, int points)
        {
            Name = name;
            Points = Convert.ToInt32(points);
        }
    }
}
