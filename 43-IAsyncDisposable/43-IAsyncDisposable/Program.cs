namespace _43_IAsyncDisposable
{
    internal class Program
    {
        static async Task Main(string[] args) // сделала, чтобы выполнялся асинхронный кусок
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ───────────────────────────────────────┐");
                Console.WriteLine("|  1 - Использовать using                                    |");
                Console.WriteLine("|  2 - Использовать async using                              |");
                Console.WriteLine("|  3 - Не использовать using (чтобы выполнился финализатор)  |");
                Console.WriteLine("|  4 - Проверить работу GC.SuppressFinalize                  |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ                  |");
                Console.WriteLine("└────────────────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":                         
                        using (DatabaseConnection db = new DatabaseConnection())
                        {
                            db.WorkWithDB();
                        }
                        break;
                    
                    case "2":
                        await using (DatabaseConnection db = new DatabaseConnection())
                        {
                            db.WorkWithDB();
                        }
                        break;

                    case "3":
                        FinaliserTest();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        break;

                    case "4":
                        FinaliserTestDispose();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        Console.WriteLine("Финализатор не сработал");
                        break;

                    default: return;
                }
            }
            static void FinaliserTest()
            {
                DatabaseConnection database = new DatabaseConnection();
                database.WorkWithDB();
            }
            static void FinaliserTestDispose()
            {
                DatabaseConnection database = new DatabaseConnection();
                database.WorkWithDB();
                database.Dispose();
            }
        }
    }
}
