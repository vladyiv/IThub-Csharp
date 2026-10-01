namespace _16_RecordsPatternMatching
{
    internal class Program
    {
        public record AttackEvent(string Attacker, string Target, int Damage);
        public record HealEvent(string Healer, string Target, int Amount);
        public record DeathEvent(string Who);

        public static string ToLogLine(object gameEvent)  => gameEvent switch
        {
            AttackEvent { Damage: > 50 } => "КРИТИЧЕСКИЙ УДАР!",
            AttackEvent a => $"{a.Attacker} атаковал персонажа {a.Target}. - {a.Damage} HP!",
            HealEvent h when h.Healer == h.Target => $"{h.Healer} подлечился сам. + {h.Amount} HP.",
            HealEvent h => $"{h.Healer} подлечил персонажа {h.Target}. + {h.Amount} HP.",
            DeathEvent d => $"{d.Who} погиб :(",
            _ => "Неизвестное событие."
        };

        public static void ShowEvents()
        {
            Console.WriteLine("Все события:");
            Console.WriteLine("- Атака с силой > 50 → \"КРИТИЧЕСКИЙ УДАР!\"");
            Console.WriteLine("- Обычная атака → \"Персонаж А атаковал Персонажа Б. - X HP!\"");
            Console.WriteLine("- Персонаж исцелил самого себя → \" Персонаж А подлечился сам. + X HP.\"");
            Console.WriteLine("- Персонаж А исцелил персонажа Б → \"Персонаж А подлечил Персонажа Б. + Х HP.\"");
            Console.WriteLine("- Персонаж умер → \"Персонаж погиб :(\"");
            Console.WriteLine("- Все остальные события → \"Неизвестное событие\".");
            Console.WriteLine();
        }

        public static void ShowAttackEvent()
        {
            bool created = false;
            int d = 0;

            Console.Write("Введите атакующего: ");
            string a = Console.ReadLine();
            Console.Write("Введите обороняющегося: ");
            string t = Console.ReadLine();
            
            while (!created)
            {
                try
                {
                    Console.Write("Введите силу удара: ");
                    d = Convert.ToInt32(Console.ReadLine());                
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
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка! " + e.Message);
                }
            }
            AttackEvent attackEvent = new AttackEvent(a, t, d);
            Console.WriteLine(ToLogLine(attackEvent));
            Console.WriteLine();
        }

        public static void ShowHealEvent()
        {
            bool created = false;
            int a = 0;

            Console.Write("Введите хиллера: ");
            string h = Console.ReadLine();
            Console.Write("Введите того, кого исцеляют: ");
            string t = Console.ReadLine();

            while (!created)
            {
                try
                {
                    Console.Write("Введите бонус исцеления: ");
                    a = Convert.ToInt32(Console.ReadLine());
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
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка! " + e.Message);
                }
            }
            HealEvent healEvent = new HealEvent(h, t, a);
            Console.WriteLine(ToLogLine(healEvent));
        }

        public static void ShowDeathEvent()
        {
            Console.Write("Введите погибшего персонажа: ");
            string w = Console.ReadLine();
            DeathEvent deathEvent = new DeathEvent(w);
            Console.WriteLine(ToLogLine(deathEvent));
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("┌─ Выберите действие  ──────────────────────────────┐");
                Console.WriteLine("|  1 - показать все возможные события\t\t    |");
                Console.WriteLine("|  2 - произвести атаку \t\t\t    |");
                Console.WriteLine("|  3 - исцелить кого-нибудь\t\t\t    |");
                Console.WriteLine("|  4 - убить кого-нибудь :) \t\t\t    |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ\t    |");
                Console.WriteLine("└───────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        ShowEvents();
                        break;
                    case "2":
                        ShowAttackEvent();
                        break;
                    case "3":
                        ShowHealEvent();
                        break;
                    case "4":
                        ShowDeathEvent();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
