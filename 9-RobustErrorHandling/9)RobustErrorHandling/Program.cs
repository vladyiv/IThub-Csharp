namespace _9_RobustErrorHandling
{
    internal class Program
    {
        public static void MatchImporter(string[] array)
        {
            int succeeded = 0, skipped = 0;
            try
            {
                foreach (string s in array)
                {
                    string[] parts = s.Split(';');
                    if ((parts.Length != 3))
                    {
                        Console.WriteLine("Пропущено: неверный формат строки!");
                        skipped++;
                        continue;
                    }
                    if (!(int.TryParse(s.Split(';')[2].Split('-')[0], out int ascore) | !(int.TryParse(s.Split(';')[2].Split('-')[0], out int bscore))))
                        {
                        Console.WriteLine("Пропущено: неверный формат строки!");
                        skipped++;
                        continue;
                    }
                    try
                    {
                        string score = s.Split(';')[2];
                        int aScore = Convert.ToInt32(score.Split('-')[0]);
                        int bScore = Convert.ToInt32(score.Split('-')[1]);
                        if (Math.Abs(aScore - bScore) > 20)
                        {
                            throw new MatchImportException("Разница в счёте не должна превышать 20!");
                        }
                        succeeded++;
                    }
                    catch (MatchImportException ex) when (ex.Message.Contains("Разница"))
                    {
                        Console.WriteLine($"Пропущено (повреждённые данные): {ex.Message}");
                        skipped++;
                    }
                }
            }
            finally
            {
                Console.WriteLine($"Итого обработано: {succeeded}, пропущено: {skipped}.");
            }
        }
        static void Main(string[] args)
        {
            MatchImporter(["Игрок1;Игрок2;3-1", "сломанная строка", "Игрок3;Игрок4;30-0", "Игрок5;Игрок6;2-2"]);
        }
    }
}


