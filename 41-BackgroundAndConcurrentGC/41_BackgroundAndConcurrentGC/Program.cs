using System.Drawing;

namespace _41_BackgroundAndConcurrentGC
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ─────────────────────────┐");
                Console.WriteLine("|  1 - Создать n объектов byte[m]              |");
                Console.WriteLine("|  2 - Заполнить массив LongLived              |");
                Console.WriteLine("|  3 - Заполнить массив HeavyLoh               |");
                Console.WriteLine("|  4 - Измерить паузу блокирующего GC.Collect  |");
                Console.WriteLine("|  5 - Очистить удержаннную память             |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ    |");
                Console.WriteLine("└──────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        (int shortAmount, int shortSize) = Logic.AskListParams();
                        TestsModule.TestResult(TestsModule.ShortLived, shortAmount, shortSize);
                        break;

                    case "2":
                        Console.Write("Сколько элементов будем вводить? ");
                        int n2 = Logic.SafeInputInt();
                        Console.Write("Какого размера сделаем массивы? ");
                        int m2 = Logic.SafeInputInt();

                        Console.WriteLine($"Проходим {n2} итераций с new byte[{m2}] и заносим в список");
                        TestsModule.TestResult(TestsModule.LongLived, n2, m2);
                        break;

                    case "3":
                        Console.Write("Сколько элементов будем вводить? ");
                        int n3 = Logic.SafeInputInt();
                        Console.Write("Какого размера сделаем массивы (нужно не меньше 85000)? ");
                        int m3 = Logic.SafeInputInt();

                        if (m3 < 85_000) Console.WriteLine("Размер меньше 85 000 байт, объекты попадут в Small Object Heap, а не в Large Object Heap!");

                        Console.WriteLine($"Проходим {n3} итераций с new byte[{m3}] и заносим в список");
                        TestsModule.TestResult(TestsModule.HeavyLoh, n3, m3);
                        break;

                    case "4":
                        TestsModule.CheckGen2Block();
                        break;

                    case "5":
                        TestsModule.Clear();                        
                        break;                        

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
