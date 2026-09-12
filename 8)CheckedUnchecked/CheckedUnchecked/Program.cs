// Вариант 1. Калькулятор сумм

namespace CheckedUnchecked
{
    internal class Program
    {
        public static int SumChecked(int[] numbers)
        {
            int sum = 0;
            try
            {
                foreach (int n in numbers)
                {
                    sum = checked(sum += n);
                }
                return sum;
            }
            catch(OverflowException)
            {
                Console.WriteLine("Ошибка: переполнение int!");
                return int.MaxValue;
            }            
        }


        static void Main(string[] args)
        {
            Console.WriteLine(SumChecked(new[] { 1, 2, 3 }));
            Console.WriteLine(SumChecked(new[] { int.MaxValue, 1 }));
            Console.WriteLine(int.TryParse("42", out var a) ? a : 0); //пытаемся конвертировать элемент из string в int и если получается, возвращаем его же
                                                                      //если возникает ошибка, возвращаем 0.
            Console.WriteLine(int.TryParse("abc", out var b) ? b : 0);
        }
    }
}