using System;
using System.Collections.Generic;
using System.Text;

namespace _2_MessagesProcessing
{
    internal class Logic
    {
        private static int SafeInputInt()
        {
            int a = 0;
            while (a <= 0)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a <= 0) Console.WriteLine("Число должно быть положительным!");
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
        public static List<string> AddToList()
        {
            List<string> list = new List<string>();
            Console.WriteLine("Сколько сообщений вы хотите ввести в список?");
            int n = SafeInputInt();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите cообщение: ");
                list.Add(Console.ReadLine());
            }
            return list;
        }
    }
}
