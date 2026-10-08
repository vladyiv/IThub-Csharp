namespace _2_MessagesProcessing
{
    internal class Program
    {
        const int minLength = 3; // для поиска слов не короче трёх символов
        static void Main(string[] args)
        {
            List<string> history = new List<string>();

            Console.WriteLine("Для начала нужно заполнить список.");
            List<string> messages = Logic.AddToList();            

            Func<string, bool> isValidLength = message => message.Length >= minLength;

            Func<string, string> messageToLog = message => $"[LOG] {message.ToUpper()}";

            Action<string> printResult = result => Console.WriteLine(result);

            Action<string> saveResult = result => history.Add(result);

            Action<string> reportMessage = printResult;
            reportMessage += saveResult;

            Console.WriteLine();
            Console.WriteLine($"Вывод сообщений не короче {minLength} символов в верхнем регистре:");
            foreach (string msg in messages)
            {
                if (isValidLength(msg))
                {
                    reportMessage(messageToLog(msg));
                }
            }
            Console.WriteLine($"Количество записей в истории: {history.Count}");
        }
    }
}
