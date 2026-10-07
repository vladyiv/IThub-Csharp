namespace _19_DelegatesAndLambda
{
    internal class Program
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
        static void Main(string[] args)
        {
            Console.WriteLine("Для начала нужно заполнить список.");
            List<string> messages = AddToList();

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
                        
                        break;
                    case "2":
                        
                        break;
                    case "3":
                        
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
