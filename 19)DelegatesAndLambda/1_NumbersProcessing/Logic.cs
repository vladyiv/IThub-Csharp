using System;
using System.Collections.Generic;
using System.Text;

namespace _1_NumbersProcessing
{
    internal class Logic
    {
        private static int SafeInputInt()
        {
            int a = 0;
            while (a == 0)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a == 0) Console.WriteLine("Число должно быть ненулевым!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат данных!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Введено слишком большое число!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка! " + e.Message);
                }
            }
            return a;
        }
        public static List<int> AddToList()
        {
            List<int> list = new List<int>();
            Console.WriteLine("Сколько чисел вы хотите ввести в список?");
            int n = SafeInputInt();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите число: ");
                int a = SafeInputInt();
                list.Add(a);
            }
            return list;
        }
    }
}
