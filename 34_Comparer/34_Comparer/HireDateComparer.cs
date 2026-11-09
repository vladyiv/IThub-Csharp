using System;
using System.Collections.Generic;
using System.Text;

namespace _34_Comparer
{
    internal class HireDateComparer : IComparer<Employee>
    {
        public int Compare(Employee? first, Employee? second) => DateTime.Compare(first.HiredDate, second.HiredDate);

        // public int Compare(Employee? first, Employee? second) => Nullable.Compare(first?.HiredDate, second?.HiredDate);
    }
}