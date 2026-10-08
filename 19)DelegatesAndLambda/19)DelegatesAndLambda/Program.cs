namespace _19_DelegatesAndLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> history = new List<string>();

            Console.WriteLine("Для начала нужно заполнить список.");
            List<string> messages = Logic.AddToList();            

            Func<string, bool> isValidLength = message => message.Length > 3;

            Func<string, string> messageToLog = message => $"[LOG] {message.ToUpper()}";

            Action<string> printResult = result => Console.WriteLine(result);

            Action<string> saveResult = result => history.Add(result);

            Action<string> reportMessage = printResult;
            reportMessage += saveResult;

            Console.WriteLine();
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
