using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _37_LINQRequests
{
    internal class Enrollment
    {
        public int StudentID, Grade;
        public string CourseName;
        public Enrollment(int studentID, string courseName, int grade)
        {
            StudentID = studentID;
            CourseName = courseName;
            Grade = grade;
        }
        public override string ToString() => $"ID студента: {StudentID}, дисциплина: {CourseName}, оценка: {Grade}.";
    }
}
