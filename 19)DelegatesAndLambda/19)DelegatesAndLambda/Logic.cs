using System;
using System.Collections.Generic;
using System.Text;

namespace _2_MessagesProcessing
{
    internal class Logic
    {
        public static List<string> AddToList()
        {
            List<string> list = new List<string>();
            Console.WriteLine("Сколько сообщений вы хотите ввести в список?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите cообщение: ");
                list.Add(Console.ReadLine());
            }
            return list;
        }
    }
}
