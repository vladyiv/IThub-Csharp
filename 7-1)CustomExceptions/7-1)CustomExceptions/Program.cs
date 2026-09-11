namespace _7_1_CustomExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // блок с неверным номером счёта
            try
            {
                new BankAccount("12345", 1000m);
            }
            catch (InvalidAccountException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            catch (BankingException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }

            // блок с выводом, превышающим баланс 
            try
            {
                new BankAccount("123456", 1000m).Withdraw(2000m);
            }
            catch (InvalidAccountException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            catch (BankingException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }

            // блок с вводом без ошибок
            try
            {
                new BankAccount("123456", 1000m).Withdraw(500m);
            }
            catch (InvalidAccountException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            catch (BankingException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
    }
}