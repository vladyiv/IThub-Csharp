namespace _13_1_EnumAndStructures
{
    internal class Program
    {
        public static void CheckSuit(string s)
        {
            if (Enum.TryParse<Suit>(s, out Suit a))
                Console.WriteLine($"Масть: {a}.");
            else
                Console.WriteLine("Несуществующая масть — без исключения");
        }
        public static void CheckRank(string r)
        {
            if (Enum.TryParse<Rank>(r, out Rank a))
                Console.WriteLine($"Ранг: {a}.");
            else
                Console.WriteLine("Несуществующий ранг — без исключения");
        }
        static void Main(string[] args)
        {
            Card[] deck = new Card[5];
            deck[0] = new Card { Suit = Suit.Hearts, Rank = Rank.King };            

            Card copy = deck[0];
            Console.WriteLine("Карта из колоды до изменения копии: " + deck[0]);
            copy.Rank = Rank.Ace;

            Console.WriteLine("Карта из колоды после изменения копии: " + deck[0]);
            Console.WriteLine("Изменённая копия: " + copy);
            Console.WriteLine();

            CheckSuit("Diamonds");
            CheckSuit("Pentacles");
            Console.WriteLine();

            CheckRank("King");
            CheckRank("Joker");
            Console.WriteLine();
        }
    }
}
