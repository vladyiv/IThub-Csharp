namespace _42_IDisposable
{
    internal class Program
    {
        static void CreateFakeResources()
        {
            FakeResource resource1 = new FakeResource();
            FakeResource resource2 = new FakeResource();
            FakeResource resource3 = new FakeResource();
        }
        static void CreateManagedResources()
        {
            ManagedResource resource1 = new ManagedResource();
            ManagedResource resource2 = new ManagedResource();
            ManagedResource resource3 = new ManagedResource();
        }

        static void UseManagedWithUsing()
        {
            using ManagedResource resource = new ManagedResource();
            Console.WriteLine("Работаем с ресурсом внутри using...");
        }        
        static void WorkWithException()
        {
            using ManagedResource handle = new ManagedResource();
            Console.WriteLine("Работаем...");
            throw new InvalidOperationException("Что-то пошло не так");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1. Создаю несколько экземпляров FakeResources");
            Console.WriteLine("--- перед CreateObjects ---");            
            CreateFakeResources();            
            Console.WriteLine("--- после CreateObjects, перед GC ---");            
            GC.Collect();
            GC.WaitForPendingFinalizers();            
            Console.WriteLine("--- после GC ---");
            Console.WriteLine();

            Console.WriteLine("2. Проверяю, на каком шаге выполнится Dispose():");
            Console.WriteLine("--- перед CreateObjects ---");
            UseManagedWithUsing();
            Console.WriteLine("--- после CreateObjects, перед GC ---");
            GC.WaitForPendingFinalizers();
            Console.WriteLine("--- после GC ---");
            Console.WriteLine();

            Console.WriteLine("3. Создаю несколько экземпляров ManageResources");
            Console.WriteLine("--- перед CreateObjects ---");
            CreateManagedResources();
            Console.WriteLine("--- после CreateObjects, перед GC ---");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("--- после GC ---");
            Console.WriteLine();

            Console.WriteLine("4. Проверяю работу Dispose() в аварийной ситуации:");
            try { WorkWithException(); }
            catch (InvalidOperationException ex) { Console.WriteLine($"Перехвачено: {ex.Message}"); }
            Console.WriteLine();

            Console.WriteLine("5. Вызываю Dispose() повторно:");
            ManagedResource resource = new ManagedResource();
            resource.Dispose();
            resource.Dispose();
        }
    }
}


//| Действие | Ожидаемый результат |
//| выход из метода с FakeResource | финализатор НЕ вызывается немедленно |
//| GC.Collect() + GC.WaitForPendingFinalizers() | финализатор вызывается |
//| ManagedResource в using-блоке | "Dispose вызван" точно в конце блока |
//| повторный вызов Dispose() | метод молча возвращается, не выводит ничего повторно |

