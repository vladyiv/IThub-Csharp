namespace _18_LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factor = 10;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ─────────────────────────────────────────────────────┐");
                Console.WriteLine("|  1 - поместить строку в кавычки                                          |");
                Console.WriteLine("|  2 - проверить строку на соответствие требованиям                        |");
                Console.WriteLine("|  3 - продемонстрировать взаимодействие с глобальной переменной           |");
                Console.WriteLine("|  4 - продемонстрировать захват переменной в цикле (забагованная версия)  |");
                Console.WriteLine("|  5 - продемонстрировать захват переменной в цикле (исправленная версия)  |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ                                |");
                Console.WriteLine("└──────────────────────────────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        HelpingClass.Quote();
                        break;
                    case "2":
                        HelpingClass.CheckString();
                        break;
                    case "3":
                        Func<int, int> multiply = a => a * factor;
                        Console.WriteLine($"Результат метода (factor = {factor}): {multiply(10)}");
                        Console.Write("Введите новое значение factor: ");
                        factor = HelpingClass.SafeInputInt();
                        Console.WriteLine($"Результат метода (factor = {factor}): {multiply(10)}");
                        break;
                    case "4":
                        HelpingClass.ActionsLoop();
                        break;
                    case "5":
                        HelpingClass.ActionsLoopFixed();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
