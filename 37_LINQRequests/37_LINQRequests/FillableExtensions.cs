using System;
using System.Collections.Generic;
using System.Text;

namespace _37_LINQRequests
{
    internal static class FillableExtensions
    {
        public static void FillList<T>(this List<T> list, Func<T> create)
        {
            Console.Write("Введите длину списка: ");
            int len = Logic.SafeInputInt();

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Ввод {i + 1}-го элемента");
                list.Add(create());
            }
        }
    }
}
