using System;
using System.Collections.Generic;
using System.Text;

namespace _34_Comparer
{
    internal class Employee : IComparable<Employee>
    {
        public string Name;
        public decimal Salary;
        public DateTime HiredDate;
        public int CompareTo(Employee other) => Salary.CompareTo(other.Salary);
        public override string ToString() => $"{Name}, зарплата: {Salary}у.е., дата приёма на работу: {HiredDate.ToString().Split(" ")[0]}.";

        public Employee(string name, decimal salary, string hiredDate)
        {
            Name = name;
            Salary = salary;
            HiredDate = Convert.ToDateTime(hiredDate);
        }
    }
}
