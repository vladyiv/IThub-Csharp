namespace _41_BackgroundAndConcurrentGC
{
    internal class Logic
    {
        public static int SafeInputInt()
        {
            int a = 0;
            while (a <= 0)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a <= 0) Console.WriteLine("Число должно быть положительным!");
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
        public static (int amount, int size) AskListParams()
        {
            Console.Write("Сколько элементов будем создавать? ");
            int amount = Logic.SafeInputInt();
            Console.Write("Какого размера сделаем массивы? ");
            int size = Logic.SafeInputInt();
            return (amount, size);
        }

    }
}

