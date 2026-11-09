using System;
using System.Collections.Generic;
using System.Text;

namespace _37_LINQRequests
{
    internal class Student
    {
        private static int _id;
        public int ID;
        public string Name;
        public Student(string name)
        {
            _id ++;
            ID = _id;
            Name = name;
        }
        public override string ToString() => $"ID: {ID}, студент: {Name}.";
    }
}
