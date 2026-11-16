namespace _39_CustomIterators
{
    internal class Program
    {
        public static void Main()
        {
            Category design = new Category("Дизайн")
            {
                Subcategories = new List<Category>
                {
                    new Category("Цифровой дизайн")
                    {
                        Subcategories = new List<Category>
                        {
                            new Category("Дизайнер интерфейсов и веб-сайтов (WEB и UX/UI)"),
                            new Category("Графический дизайнер и дизайнер анимации (motion дизайнер)")
                        }
                    },
                    new Category("Дизайн среды")
                    {
                        Subcategories = new List<Category>
                        {
                            new Category("Дизайнер среды")
                        }
                    },
                    new Category("Промышленный дизайн")
                    {
                        Subcategories = new List<Category>
                        {
                            new Category("Промышленный дизайнер")
                        }
                    }
                }
            };

            Category filmProduction = new Category("Кинопроизводство")
            {
                Subcategories = new List<Category>
                {
                    new Category("Режиссёрское мастерство"),
                    new Category("Сценарное мастерство"),
                    new Category("Продюсерское мастерство"),
                    new Category("Техническое мастерство (кинооператор, звукорежиссёр)"),
                    new Category("Специалист по актёрскому кастингу (актёрское мастерство)")
                }
            };
            Category programming = new Category("Программирование и управление ИТ-продуктом")
            {
                Subcategories = new List<Category>
            {
            new Category("Разработка")
            {
                Subcategories = new List<Category>
                {
                    new Category("Веб-разработчик"),
                    new Category(".NET- разработчик"),
                    new Category("JAVA- разработчик")
                }
            },
            new Category("Программирование")
            {
                Subcategories = new List<Category>
                {
                    new Category("Веб-разработчик"),
                    new Category(".NET- разработчик"),
                    new Category("JAVA- разработчик")
                }
            },
            new Category("Управление ИТ-проектами")
            {
                Subcategories = new List<Category>
                {
                    new Category("Менеджер ИТ-проектов")
                }
            },
            new Category("Искусственный интеллект в работе с данными")
            {
                Subcategories = new List<Category>
                {
                    new Category("Дата-инженер"),
                    new Category("Дата-аналитик")
                }
            }
                }
            };

            Category itHub = new Category("IThub колледж")
            {
                Subcategories = new List<Category>
                {
                    design,
                    filmProduction,
                    programming
                }
            };

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ─────────────────────────────────────────┐");
                Console.WriteLine("|  1 - Добавить подкатегорию в категорию \"IThub колледж\"       |");
                Console.WriteLine("|  2 - Вывести все категории и подкатегории                    |");
                Console.WriteLine("|  3 - Вывести только \"листья\" дерева (только специальности)   |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ                    |");
                Console.WriteLine("└──────────────────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        itHub.AddCategory();
                        break;

                    case "2":
                        foreach (var category in itHub) Console.WriteLine(category.Name);
                        Console.WriteLine();
                        break;

                    case "3":
                        foreach (var category in itHub.Leaves()) Console.WriteLine(category.Name);
                        Console.WriteLine();
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

