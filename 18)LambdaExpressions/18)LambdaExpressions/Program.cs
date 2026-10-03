namespace _18_LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Action> actions = new List<Action>();
            for (int i = 0; i < 3; i++)
            {
                actions.Add(() => Console.WriteLine(i));
                Console.WriteLine($"В качестве аргумента {i+1}-му элементу присвоено число {i}.");
            }
            Console.WriteLine("Результат выполнения действий:");
            foreach (Action a in actions) a();
        }
    }
}
