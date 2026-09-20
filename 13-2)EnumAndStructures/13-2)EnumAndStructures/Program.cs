namespace _13_2_EnumAndStructures
{
    internal class Program
    {
        public static void CheckRarity(string r)
        {
            if (Enum.TryParse<ItemRarity>(r, out ItemRarity a))
                Console.WriteLine($"Редкость: {a}.");
            else
                Console.WriteLine("Несуществующая редкость — без исключения");
        }

        public static void CheckSlot(string s)
        {
            if (Enum.TryParse < ItemSlot>(s, out ItemSlot a))
                Console.WriteLine($"Категория: {a}.");
            else
                Console.WriteLine("Несуществующая категория — без исключения");
        }

        static void Main(string[] args)
        {
            Item[] inventory = new Item[5];
            inventory[0] = new Item { Name = "Меч дракона", Rarity = ItemRarity.Legendary, Slot = ItemSlot.Weapon };

            Item copy = inventory[0];
            Console.WriteLine("Предмет из инвентаря до изменения копии: " + inventory[0]);
            copy.Rarity = ItemRarity.Common;

            Console.WriteLine("Предмет из инвентаря после изменения копии: " + inventory[0]);
            Console.WriteLine("Изменённая копия: " + copy);
            Console.WriteLine();

            CheckRarity("Epic");
            CheckRarity("Mythic");
            Console.WriteLine();

            CheckSlot("Armor");
            CheckSlot("Supply");
        }
    }
}