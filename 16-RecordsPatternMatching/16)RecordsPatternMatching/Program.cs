namespace _16_RecordsPatternMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("┌─ Выберите действие  ──────────────────────────────┐");
                Console.WriteLine("|  1 - показать все возможные события\t\t    |");
                Console.WriteLine("|  2 - произвести атаку \t\t\t    |");
                Console.WriteLine("|  3 - исцелить кого-нибудь\t\t\t    |");
                Console.WriteLine("|  4 - убить кого-нибудь >:) \t\t\t    |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ\t    |");
                Console.WriteLine("└───────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        Events.ShowEvents();
                        break;
                    case "2":
                        Events.ShowAttackEvent();
                        break;
                    case "3":
                        Events.ShowHealEvent();
                        break;
                    case "4":
                        Events.ShowDeathEvent();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }           

        }
    }
}

//| Вход | Ожидаемый результат |
//| new AttackEvent("Герой", "Дракон", 75) | "КРИТИЧЕСКИЙ УДАР: ..." |
//| new AttackEvent("Герой", "Дракон", 10) | обычная строка лога об атаке |
//| new HealEvent("Жрец", "Жрец", 20) | "... подлечился сам" |
//| new HealEvent("Жрец", "Воин", 20) | обычная строка лога о лечении |
//| new DeathEvent("Дракон") | "Дракон погиб" |
