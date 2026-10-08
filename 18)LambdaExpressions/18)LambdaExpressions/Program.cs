namespace _18_LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int countNumber = 3; // по условию лямбда вызывается 3 раза
            int factor = 10; // ...

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
                        Console.WriteLine();
                        Console.WriteLine("Добавление кавычек (Func<string, string>)");
                        Console.Write("Введите слово или фразу: ");
                        string word = HelpingClass.SafeInputString();

                        Func<string, string> quote = word => '"' + word + '"';

                        Console.WriteLine(quote(word));
                        break;
                    
                    case "2":
                        Console.WriteLine();
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
                        break;
                    
                    case "3":
                        Func<int, int> multiply = a => a * factor;
                        Console.WriteLine();                        
                        Console.WriteLine($"Результат метода (factor = {factor}): {multiply(10)}");
                        Console.Write("Введите новое значение factor: ");
                        factor = HelpingClass.SafeInputInt();
                        Console.WriteLine($"Результат метода (factor = {factor}): {multiply(10)}");
                        break;
                    
                    case "4":
                        Console.WriteLine();
                        Console.WriteLine("Захват переменной в цикле (() => Console.WriteLine(i), забагованная версия)");

                        List<Action> actions = new List<Action>();
                        Console.WriteLine("Изменение i в цикле:");
                        for (int i = 0; i < countNumber; i++)
                        {
                            actions.Add(() => Console.WriteLine($"i = {i}."));
                            Console.WriteLine($"i = {i}.");
                        }

                        Console.WriteLine("Результат выполнения действий:");
                        foreach (Action a in actions) a();
                        break;
                    
                    case "5":
                        Console.WriteLine();
                        Console.WriteLine("Захват переменной в цикле (() => Console.WriteLine(n), исправленная версия)");

                        List<Action> actionsFixed = new List<Action>();
                        Console.WriteLine("Изменение i и n в цикле:");
                        for (int i = 0; i < countNumber; i++)
                        {
                            int n = i;
                            actionsFixed.Add(() => Console.WriteLine($"i = {i}, n = {n}."));
                            Console.WriteLine($"i = {i}, n = {n}.");
                        }

                        Console.WriteLine("Результат выполнения действий:");
                        foreach (Action a in actionsFixed) a();
                        break;
                    
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
