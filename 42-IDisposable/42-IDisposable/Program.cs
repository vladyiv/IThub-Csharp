namespace _42_IDisposable
{
    internal class Program
    {
        static void CreateFakeResources()
        {
            FakeResource resourse1 = new FakeResource();
            FakeResource resourse2 = new FakeResource();
            FakeResource resourse3 = new FakeResource();
            FakeResource resourse4 = new FakeResource();
            FakeResource resourse5 = new FakeResource();
        }
        static void UseManagedWithUsing()
        {
            using var resource = new ManagedResource();
            Console.WriteLine("Работаем с ресурсом внутри using...");
        }
        static void CreateManagedResources()
        {
            ManagedResource resourse1 = new ManagedResource();
            ManagedResource resourse2 = new ManagedResource();
            ManagedResource resourse3 = new ManagedResource();
            ManagedResource resourse4 = new ManagedResource();
            ManagedResource resourse5 = new ManagedResource();
        }
        static void WorkWithException()
        {
            using var handle = new ManagedResource();
            Console.WriteLine("Работаем...");
            throw new InvalidOperationException("Что-то пошло не так");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Создаём несколько экземпляров FakeResources");
            Console.WriteLine("--- перед CreateObjects ---");
            CreateFakeResources();
            Console.WriteLine("--- после CreateObjects, перед GC ---");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("--- после GC ---");
            Console.WriteLine();

            Console.WriteLine("Проверяем, на каком шаге выполнится Dispose():");
            Console.WriteLine("--- перед CreateObjects ---");
            UseManagedWithUsing();
            Console.WriteLine("--- после CreateObjects, перед GC ---");
            GC.WaitForPendingFinalizers();
            Console.WriteLine("--- после GC ---");

            Console.WriteLine("Создаём несколько экземпляров ManageResources");
            Console.WriteLine("--- перед CreateObjects ---");
            CreateManagedResources();
            Console.WriteLine("--- после CreateObjects, перед GC ---");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("--- после GC ---");
            Console.WriteLine();

            Console.WriteLine("Проверяем работу Dispose() в аварийной ситуации:");
            try { WorkWithException(); }
            catch (InvalidOperationException ex) { Console.WriteLine($"Перехвачено: {ex.Message}"); }
        }
    }
}
