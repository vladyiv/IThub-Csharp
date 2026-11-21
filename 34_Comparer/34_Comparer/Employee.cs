using System;
using System.Collections.Generic;
using System.Text;

namespace _34_Comparer
{
    internal class Employee : IComparable<Employee>
    {
        public int ID;
        public string Name;
        public decimal Salary;
        public DateTime HiredDate;
        public int CompareTo(Employee other) => Salary.CompareTo(other.Salary);
        public override string ToString() => $"ID: {ID}, {Name}, зарплата: {Salary} у.е., дата приёма на работу: {HiredDate.ToString().Split(" ")[0]}.";

        public Employee(int id, string name, decimal salary, string hiredDate)
        {
            ID = id;
            Name = name is null ? "-" : name;
            Salary = salary;
            HiredDate = hiredDate is null ? DateTime.Today : Convert.ToDateTime(hiredDate);
        }
    }
}
