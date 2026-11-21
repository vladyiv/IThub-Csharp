using System;
using System.Collections.Generic;
using System.Text;

namespace _36_LINQGrouping
{
    internal class Student
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public Student(string name, int points)
        {
            Name = name;
            Points = points;
        }
    }
}
