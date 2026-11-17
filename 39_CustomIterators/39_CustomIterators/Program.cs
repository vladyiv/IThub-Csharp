namespace _39_CustomIterators
{
    internal class Program
    {
        public static void Main()
        {
            Category itHub = Category.LoadFromTxt("../../../../categories.txt");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ───────────────────────────────────────────────────────────────┐");
                Console.WriteLine("|  1 - Добавить подкатегорию в категорию \"IThub колледж\"                             |");
                Console.WriteLine("|  2 - Вывести все категории и подкатегории                                          |");
                Console.WriteLine("|  3 - Вывести только листья дерева                                                  |");
                Console.WriteLine("|  4 - Вывести дерево категорий (сделала с помощью нейронки просто для наглядности)  |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ                                          |");
                Console.WriteLine("└────────────────────────────────────────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Введите максимальный уровень вложенности: ");
                        int maxLevels = Logic.SafeInputIntPos();
                        itHub.FillSubcategories(1, maxLevels);
                        break;

                    case "2":
                        Console.WriteLine("Все категории");
                        Console.WriteLine();
                        foreach (Category category in itHub) Console.WriteLine(category.Name);
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.WriteLine("Вывод только листьев (категорий без подкатегорий)");
                        Console.WriteLine();
                        foreach (Category category in itHub.Leaves()) Console.WriteLine(category.Name);
                        Console.WriteLine();
                        break;

                    case "4":
                        Console.WriteLine("Дерево всех категорий (для представления вложенности)");
                        Console.WriteLine();
                        itHub.PrintTree();
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

