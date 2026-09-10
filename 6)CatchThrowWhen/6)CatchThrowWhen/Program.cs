// Вариант 1. Парсер списка чисел

namespace _6_CatchThrowWhen
{
    internal class Program
    {
        public static int SumValidNumbers(List<string> values)
        {
            int sum = 0, count = 0;
            foreach (string value in values)
            {
                count++;
                try
                {
                    Console.WriteLine($"{sum} + {int.Parse(value)}");
                    sum += int.Parse(value);
                    Console.WriteLine($"Сумма: {sum}.");

                }
                catch (FormatException) when (string.IsNullOrWhiteSpace(value))
                {

                }
                catch (FormatException)
                {
                    Console.WriteLine("Обнаружен элемент неверного формата!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: переполнение int!");
                    throw;
                }
                finally
                {
                    Console.WriteLine($"{count}-й обработанный элемент");
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Первый массив");
            Console.WriteLine(SumValidNumbers(["10", "", "abc", "20"])); // возвращает 30
            Console.WriteLine("\nВторой массив");
            Console.WriteLine(SumValidNumbers(["99999999999", "1", "abc"])); // срабатывает ошибка на первом элементе, и программа даже не доходит до следующих элементов
        }
    }
}