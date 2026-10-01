namespace _15_PatternMatching
{
    internal class Program
    {
        public static string BattleOutcome((int attackerHp, int defenderHp) result) => result switch
        {
            ( <= 0, > 0) => "Defender победил.",
            ( > 0, <= 0) => "Attacker победил.",
            (0, 0) => "Оба пали.",
            ( < 0, < 0) => "Оба пали, срочно нужен хилинг!",
            _ when ((result.attackerHp > 0) & (result.defenderHp >= 2 * result.attackerHp)) => "Defender в большом преимуществе.",
            _ => "Бой продолжается..."
        };

        public static void CreateBattle()
        {
            bool created = false;
            int a = 0, d = 0;
            while (!created)
            {
                try
                {
                    Console.WriteLine();
                    Console.Write("Введите HP атакущего: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите HP обороняющегося: ");
                    d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    created = true;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат данных!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Введено слишком большое число!");
                }
            }
            Console.WriteLine(BattleOutcome((a, d)));
            Console.WriteLine();
        }

        public static void ShowOutcomes()
        {
            Console.WriteLine();
            Console.WriteLine("Все возможные исходы боя:");
            Console.WriteLine("- HP атакующего <= 0, HP обороняющегося > 0 → \"Defender победил\".");
            Console.WriteLine("- HP атакующего > 0, HP обороняющегося <= 0 → \"Attacker победил\".");
            Console.WriteLine("- HP у обоих на нуле → \"Оба пали\".");
            Console.WriteLine("- HP обоих < 0 → Оба пали, срочно нужен хилинг!");
            Console.WriteLine("- Оба живы, но attackerHp меньше defenderHp более чем в 2 раза → \"Defender в большом преимуществе\".");
            Console.WriteLine("- Все остальные случаи → \"бой продолжается\".");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("┌───── Выберите действие  ──────────────────────────┐");
                Console.WriteLine("|  1 - показать все возможные исходы боя\t    |");
                Console.WriteLine("|  2 - ввести HP персонажей \t\t\t    |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ\t    |");
                Console.WriteLine("└───────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        ShowOutcomes();
                        break;
                    case "2":
                        CreateBattle();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
