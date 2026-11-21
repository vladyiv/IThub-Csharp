using System;
using System.Collections.Generic;
using System.Text;

namespace _17__ActionFuncPredicate
{
    internal class HelpingClass
    {
        private static string SafeInputString()
        {
            string a = "";
            while (a == "")
            {
                a = Console.ReadLine();
                if (a == "") Console.WriteLine("Пустая строка не принимается!");
            }
            return a;
        }

        public static List<string> AddToList(List<string> list) 
        {
            Console.WriteLine("Сколько пользователей вы хотите ввести в список?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите имя пользователя: ");
                list.Add(SafeInputString());
            }
            return list;
        }

        public static void Welcome(Action<string> action, List<string> list)
        {
            Console.WriteLine();
            Console.WriteLine("Приветствуем всех пользователей в списке (Action<string>)");
            foreach (string l in list) action(l);
        }

        public static void Normalize(Func<string, string> func)
        {
            Console.WriteLine();
            Console.WriteLine("Приведение имени к нижнему регистру (Func<string, string>)");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Имя {name} в нижнем регистре: {func(name)}.");
        }

        public static void IsTooShort(Predicate<string> predicate, List<string> list)
        {
            Console.WriteLine();
            Console.WriteLine("Поиск первого короткого имени (Predicate<string>)");
            string? tooShort = list.Find(predicate);
            if (!(tooShort is null)) Console.WriteLine($"Первый элемент в списке короче 3 букв: {tooShort}.");
            else Console.WriteLine("В списке не найдено элементов короче 3 букв :(");
        }
    }
}
