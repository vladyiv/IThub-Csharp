using System;
using System.Collections.Generic;
using System.Text;

namespace _35_LINQIntro
{
    internal class Student
    {
        public string Name, Course;
        public int Points;
        public override string ToString() => $"Студент: {Name}, дисциплина: \"{Course}\", баллы: {Points};";
        public Student(string name, string course, int points)
        {
            Name = name is null ? "неизвестный" : name;
            Course = course is null ? "неизвестная дисциплина" : course;
            Points = Convert.ToInt32(points);
        }
    }
}
