// Вариант 2. Трёхуровневая цепочка вызовов

using System.Collections;

namespace ExceptionsHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserService myUserService = new UserService();

            Console.WriteLine(myUserService.GetUserAgeSafe(1)); // вернёт 18
            Console.WriteLine(myUserService.GetUserAgeSafe(999)); // выдаст ошибку InvalidOperationException с нашим комментарием

            Repository myRepository = new Repository();
            Console.WriteLine(myRepository.GetUserAge(1)); // вернёт 18
            Console.WriteLine(myRepository.GetUserAge(999)); // выдаст ошибку KeyNotFoundException            

            try
            {
                UserService u = new UserService();
                int id = u.GetUserAgeSafe(10); // выдаст ошибку InvalidOperationException с нашим комментарием
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сообщение: {ex.Message}"); // то самое сообщение, которое мы писали в GetUserAgeSafe
                Console.WriteLine($"Исходная причина: {ex.InnerException?.Message}"); // системное сообщение ошибки
                foreach (DictionaryEntry entry in ex.Data) // словарь IDictionary, позволяющий приложить к исключению произвольные пары «ключ — значение»
                    Console.WriteLine($"{entry.Key}: {entry.Value}"); // в нашем случае аргумент один, поэтому и вывод будет только один (но если было бы несколько, вывелся бы каждый)
            }
        }
    }
}