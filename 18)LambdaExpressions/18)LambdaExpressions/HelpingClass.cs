using System;
using System.Collections.Generic;
using System.Text;

namespace _18_LambdaExpressions
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

        public static int SafeInputInt()
        {
            int a;
            while (true)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    break;
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

        public static void Quote()
        {
            Console.WriteLine("Добавление кавычек (Func<string, string>)");
            Console.Write("Введите слово или фразу: ");
            string word = SafeInputString();
            Func<string, string> quote = word => '"' + word + '"';
            Console.WriteLine(quote(word));
        }

        public static void CheckString()
        {
            Console.WriteLine("Проверка строки (Func<string, bool>)");
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            Func<string, bool> checkString = s =>
            {
                bool isValid = s.Replace(" ", "").Length != 0 & s.Length > 3;
                return isValid;
            };
            if (checkString(input)) Console.WriteLine($"Строка \"{input}\" соответствует требованиям (не пустая и длиннее трёх символов)!");
            else Console.WriteLine($"Строка \"{input}\" не соответствует требованиям (пустая и/или короче трёх символов)!");
        }

        public static void ActionsLoop()
        {
            Console.WriteLine("Захват переменной в цикле (() => Console.WriteLine(n), забагованная версия)");
            List<Action> actions = new List<Action>();
            Console.WriteLine("Изменение i в цикле:");
            for (int i = 0; i < 3; i++)
            {
                actions.Add(() => Console.WriteLine($"i = {i}."));
                Console.WriteLine($"i = {i}.");
            }
            Console.WriteLine("Результат выполнения действий:");
            foreach (Action a in actions) a();
        }

        public static void ActionsLoopFixed()
        {
            Console.WriteLine("Захват переменной в цикле (() => Console.WriteLine(i), исправленная версия)");
            List<Action> actionsFixed = new List<Action>();
            Console.WriteLine("Изменение i и n в цикле:");
            for (int i = 0; i < 3; i++)
            {
                int n = i;
                actionsFixed.Add(() => Console.WriteLine($"i = {i}, n = {n}."));
                Console.WriteLine($"i = {i}, n = {n}.");
            }
            Console.WriteLine("Результат выполнения действий:");
            foreach (Action a in actionsFixed) a();
        }
    }
}
