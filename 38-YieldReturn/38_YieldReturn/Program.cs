namespace _38_YieldReturn
{
    internal class Program
    {
        public static IEnumerable<int> Fibonacci()
        {
            int a = 0, b = 1;
            while (true)
            {
                Console.Write($"Готовится число {a}: ");
                yield return a;
                (a, b) = (b, a + b);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            // foreach (int i in Fibonacci().Take(10)) Console.WriteLine(i);

            //List<int> list = new List<int>();
            //foreach (int i in Fibonacci().Take(10)) list.Add(i);
            //foreach (int i in list) Console.WriteLine(i);

             //Console.WriteLine(Fibonacci().ToList()); // полетит
            Console.WriteLine(Fibonacci().Take(10).ToList()); // будет только вывод перед yield и List в конце
        }
    }
}
