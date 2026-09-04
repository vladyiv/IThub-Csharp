using TrueFalseOverloading;

namespace TrueFalseOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(2, 4);
            Fraction f3 = new Fraction(3, 4);

            Console.WriteLine($"Проверка 1/2 == 2/4:  {f1 == f2}");
            Console.WriteLine($"Проверка 1/2 < 3/4:  {f1 < f3}");
            Console.WriteLine($"Проверка (1/2).GetHashCode() == (2/4).GetHashCode():  {f1.GetHashCode() == f2.GetHashCode()}");
            if (new Fraction(0, 5))
            {
                Console.WriteLine("Дробь не равна нулю."); // не выведется
            };

            Fraction f4 = new Fraction(1, -2);
            Console.WriteLine($"Вывод значений дроби (1, -2): {f4.ToString()}");
        }
    }
}