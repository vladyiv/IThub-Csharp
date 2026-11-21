using System;
using System.Collections.Generic;
using System.Text;

namespace _16_RecordsPatternMatching
{
    public record AttackEvent(string Attacker, string Target, int Damage);
    public record HealEvent(string Healer, string Target, int Amount);
    public record DeathEvent(string Who);
    internal class Events
    {
        private static readonly List<string> deadCharacters = new List<string>();

        public static string ToLogLine(object gameEvent) => gameEvent switch
        {
            AttackEvent { Damage: > 50 } => "КРИТИЧЕСКИЙ УДАР!",
            AttackEvent a => $"{a.Attacker} атаковал персонажа {a.Target}. -{a.Damage}HP!",
            HealEvent h when h.Healer == h.Target => $"{h.Healer} подлечился сам. +{h.Amount}HP.",
            HealEvent h => $"{h.Healer} подлечил персонажа {h.Target}. +{h.Amount}HP.",
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

        private static string SafeInputString()
        {
            string a = "";
            while (a == "")
            {
                a = Console.ReadLine();
                if (a == "") Console.WriteLine("Пустая строка не принимается!");
            }
            return a;
        }

        private static int SafeInputInt()
        {
            int a = 0;
            while (a <= 0)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a <= 0) Console.WriteLine("Число должно быть положительным!");
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
            return a;
        }

        public static void ShowAttackEvent()
        {
            Console.Write("Введите атакующего: ");
            string a = SafeInputString();

            Console.Write("Введите обороняющегося: ");
            string t = SafeInputString();

            Console.Write("Введите силу удара: ");
            int d = SafeInputInt();

            AttackEvent attackEvent = new AttackEvent(a, t, d);
            Console.WriteLine(ToLogLine(attackEvent));
            Console.WriteLine();
        }

        public static void ShowHealEvent()
        {
            Console.Write("Введите хиллера: ");
            string h = SafeInputString();

            Console.Write("Введите того, кого исцеляют: ");
            string t = SafeInputString();

            Console.Write("Введите бонус исцеления: ");
            int a = SafeInputInt();

            HealEvent healEvent = new HealEvent(h, t, a);
            Console.WriteLine(ToLogLine(healEvent));
            Console.WriteLine();
        }

        public static void ShowDeathEvent()
        {
            while (true)
            {
                string w = "";
                Console.Write("Введите погибшего персонажа: ");
                w = Console.ReadLine();
                if (deadCharacters.Contains(w))
                {
                    Console.WriteLine($"Персонаж {w} уже мёртв!");
                    continue;
                }
                deadCharacters.Add(w);
                DeathEvent deathEvent = new DeathEvent(w);
                Console.WriteLine(ToLogLine(deathEvent));
                Console.WriteLine();
                break;
            }
        }
    }
}
