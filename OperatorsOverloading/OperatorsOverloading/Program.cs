namespace OperatorsOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector2D myVector1 = new Vector2D(1, 2);
            Vector2D myVector2 = new Vector2D(3, 4);

            Console.WriteLine($"myVector1: {myVector1.ToString()}");
            Console.WriteLine($"myVector2: {myVector2.ToString()}");

            Console.WriteLine("\nОперации v1+v2, v1-v2, -v1, v1*a, a*v1");

            Console.WriteLine($"\nmyVector1 + myVector2: {(myVector1 + myVector2).ToString()}");
            Console.WriteLine($"myVector1 - myVector2: {(myVector1 - myVector2).ToString()}");
            Console.WriteLine($"-myVector1: {(-myVector1).ToString()}");
            Console.WriteLine($"myVector1 * 2: {(myVector1 * 2).ToString()}");
            Console.WriteLine($"2 * myVector1: {(2 * myVector1).ToString()}"); // работает с любым порядком параметров
            Console.WriteLine($"myVector1 * 10,57934: {(myVector1 * 10.57934).ToString()}"); // для демонстрации округления

            Console.WriteLine("\nПереприсваивание +=, -=, *=, v1=-v1");

            myVector2 += myVector1;
            Console.WriteLine($"\nmyVector2 (переприсвоила значение, полученное при сложении с myVector1): {myVector2.ToString()}");
            myVector2 -= myVector1;
            Console.WriteLine($"\nmyVector2 (переприсвоила значение, полученное при вычитании myVector1): {myVector2.ToString()}");
            myVector2 *= 10.57934;
            Console.WriteLine($"myVector2 (переприсвоила значение, полученное при умножении на 10,57934): {myVector2.ToString()}");
            myVector2 = -myVector2;
            Console.WriteLine($"myVector2 (переприсвоила значение противоположно направленного вектора): {myVector2.ToString()}");
        }
    }
}
