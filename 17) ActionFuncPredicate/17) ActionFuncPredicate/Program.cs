namespace _17__ActionFuncPredicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перед началом нужно заполнить список пользователей!");
            List<string> usernames = HelpingClass.AddToList(new List<string>());

            Action<string> welcome = name => Console.WriteLine($"Добрый день, {name}!");
            Func<string, string> normalize = name => name.ToLower();
            Predicate<string> isTooShort = name => name.Length < 3;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ────────────────────────────────┐");
                Console.WriteLine("|  1 - поприветствовать всех пользователей            |");
                Console.WriteLine("|  2 - привести имя к нижнему регистру                |");
                Console.WriteLine("|  3 - найти первого пользователя с коротким именем   |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ           |");
                Console.WriteLine("└─────────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        HelpingClass.Welcome(welcome, usernames);
                        break;
                    case "2":
                        HelpingClass.Normalize(normalize);
                        break;
                    case "3":
                        HelpingClass.IsTooShort(isTooShort, usernames);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }

            //bool isValidName(string name) => name.Length > 2;
            //Predicate<string> predicate = isValidName;
            //Func<string, bool> func = isValidName;

            //Predicate<string> mixed = func;
        }
    }
}

// 