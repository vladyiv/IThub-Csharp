namespace _32_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> history = new LinkedList<string>();
            history.AddLast("newlxp.ru");
            history.AddLast("e.mail.ru");
            history.AddLast("youtube.com");
            history.AddLast("metanit.com");

            LinkedListNode<string> currentPage = history.Last;

            void Visit(string url)
            {
                if (history.Find(url) is not null) currentPage = history.Find(url);
                else currentPage = history.AddAfter(currentPage, url);
            }

            void DeleteURL(string url)
            {
                LinkedListNode<string> deleted = history.Find(url);
                if (deleted == currentPage)
                {
                    if (deleted.Previous is not null) currentPage = deleted.Previous;
                    else currentPage = deleted.Next;
                }
                try { history.Remove(deleted); }
                catch { Console.WriteLine($"Вкладка {url} не найдена!"); }
            }

            void PrintHistory()
            {
                foreach (string node in history)
                {
                    if (history.Find(node) == currentPage) Console.WriteLine("> " + node + " (текущая вкладка)");
                    else Console.WriteLine(node);
                }
                Console.WriteLine();
            }

            void TryFind(string url)
            {
                if (history.Find(url) is not null) Console.WriteLine(history.Find(url));
                else Console.WriteLine($"Вкладка {url} не найдена!");
            }

            PrintHistory();

            Console.WriteLine("Посетили вкладку e.mail.ru");
            Visit("e.mail.ru");
            PrintHistory();

            Console.WriteLine("Открыли вкладку yandex.ru");
            Visit("yandex.ru");
            PrintHistory();

            Console.WriteLine("Открыли вкладку github.com");
            Visit("github.com");
            PrintHistory();

            Console.WriteLine("Удалили вкладку github.com");
            DeleteURL("github.com");
            PrintHistory();

            Console.WriteLine("Попытались найти в списке удалённую вкладку");
            TryFind("github.com");
            Console.WriteLine();

            Console.WriteLine("Попытались удалить уже удалённую вкладку");
            DeleteURL("github.com");
        }
    }
}

//| Действие | Ожидаемый результат |
//| PlayNext("X") | список становится ["A", "X", "B", "C"] |
//| Find("B"), затем Remove("B") | список становится ["A", "X", "C"] |
//| Find("Нет такой песни") | null |

