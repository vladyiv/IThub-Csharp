namespace RecordStruct
{
    public record Vector3(double X, double Y, double Z)
    {
        public double Length => Math.Sqrt(X * X + Y * Y + Z * Z);
        public override string ToString() => $"Vector({X}, {Y}, {Z}), Length: {Math.Round(Length, 2)}.";
    }
    public record struct Vector3Struct(double X, double Y, double Z)
    {
        public override string ToString() => $"Vector({X}, {Y}, {Z}).";
    };

    internal class Program
    {
        public static Vector3 createVector()
        {
            try
            {
                Console.Write("Введите координату X: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите координату Y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите координату Z: ");
                int z = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Новый вектор со значениями ({x}, {y}, {z}) создан!");
                Console.WriteLine();
                return new Vector3(x, y, z);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат введённых данных!");
                Console.WriteLine($"Новый вектор со значениями (0, 0, 0) создан!");
                Console.WriteLine();
                return new Vector3(0, 0, 0);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Создаём первый вектор.");
            Vector3 v1 = createVector();
            Console.WriteLine("Создаём второй вектор.");
            Vector3 v2 = createVector();

            Console.WriteLine($"Сравниваем v1 и v2: {v1 == v2}.");
            Console.WriteLine();

            Vector3 v3 = v1 with { Z = 0 };
            Console.WriteLine("v1 (оригинал): " + v1);
            Console.WriteLine("v3 (копия): " + v3);
            Console.WriteLine($"Сравниваем v1 и v3: {v1 == v3}.");
            Console.WriteLine();

            (double x, double y, double z) = v3;
            Console.WriteLine($"Переменные, взятые из вектора v3: x = {x}, y = {y}, z = {z}.");

            Vector3Struct v4 = new Vector3Struct(1, 1, 1);
            Console.WriteLine(v4);
            v4.X = 10;
            Console.WriteLine(v4);
            // v3.X = 10;
        }
    }
}






//public record Vector3(double X, double Y, double Z) с дополнительным вычисляемым свойством Length (через Math.Sqrt(XX + YY + Z*Z)), добавленным в тело записи помимо позиционных параметров.
//Создайте два экземпляра Vector3 с одинаковыми координатами и продемонстрируйте, что == возвращает true.
//Используйте with, чтобы создать копию с изменённым Z, и выведите оригинал и копию, доказав, что оригинал не изменился (включая то, что Length пересчитывается для копии).
//Продеконструируйте Vector3 в переменные x, y, z.
//Объявите public record struct Vector3Struct(double X, double Y, double Z) и продемонстрируйте, что X можно изменить напрямую — в отличие от Vector3.X.
