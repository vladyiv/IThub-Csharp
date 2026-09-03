namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("Kia");
            Car car3 = new Car("Lada", "B123BB");
            Car car4 = new Car("Volvo", "E321KX", "Red");
            Car car5 = new Car(car4);

            Console.WriteLine($"Объект с пустым  конструктором: {car1.Brand} {car1.Number} {car1.Color}.");
            Console.WriteLine($"Объект с одним параметром: {car2.Brand} {car2.Number} {car2.Color}.");
            Console.WriteLine($"Объект с двумя параметрами: {car3.Brand} {car3.Number} {car3.Color}.");
            Console.WriteLine($"Объект с полным конструктором: {car4.Brand} {car4.Number} {car4.Color}.");
            Console.WriteLine($"Объект с объектом класса Car (копирует значения полей предыдущего объекта): {car5.Brand} {car5.Number} {car5.Color}.");
            {
                MyArr arr = new MyArr(10);
                arr[0] = 5;
                arr[4.51] = 12;
                arr[9.49] = 3;
                //arr[99.9] = 18; - код выполнен ниже с try-catch, чтобы не ломать программу, но показать ошибку.
                arr[3.9] = 1;

                Console.WriteLine("\n\nПолучившийся массив: ");
                for (int i = 0; i < arr.Length; i++)
                    Console.Write("{0}\t", arr[i]);

                try
                {
                    arr[99.9] = 18;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\nОшибка при попытке выполнить код 'arr[99.9] = 18':\n" + e.ToString());
                }

                Console.ReadLine();
            }

        }
    }

}
