namespace _1_NumbersProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> history = new List<int>();
            
            Console.WriteLine("Для начала нужно заполнить список.");
            List<int> numbers = Logic.AddToList();

            Func<int, bool> isEven = num => num % 2 == 0;

            Func<int, int> squareNum = num => num * num;

            Action<int> reportMessage = result =>
            {
                Console.WriteLine($"[LOG] {result}");
                history.Add(result);
            };
           

            Console.WriteLine();
            Console.WriteLine("Вывод чётных чисел, возведённых в квадрат:");
            foreach (int num in numbers)
            {
                if (isEven(num))
                {
                    reportMessage(squareNum(num));
                }
            }
            Console.WriteLine($"Количество записей в истории: {history.Count}");
        }
    }
}
