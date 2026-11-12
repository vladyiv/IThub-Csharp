using System;
using System.Collections.Generic;
using System.Text;

namespace _34_Comparer
{
    internal class HireDateComparer : IComparer<Employee>
    {
        public int Compare(Employee first, Employee second) => DateTime.Compare(first.HiredDate, second.HiredDate);

        //public int Compare(Employee? first, Employee? second)
        //{
        //    if (first == null && second == null) return 0;
        //    if (first == null) return -1;
        //    if (second == null) return 1;
        //    return DateTime.Compare(first.HiredDate, second.HiredDate);
        //} 
    }
}