namespace _12_EnumAndStructures
{
    internal class Program
    {
        public static void CheckRarity(string r)
        {
            if (Enum.TryParse<ItemRarity>(r, out ItemRarity a))
                Console.WriteLine($"Редкость предмета: {a}.");
            else
                Console.WriteLine("Несуществующая редкость — без исключения");
        }
        static void Main(string[] args)
        {
            ItemSlot myItem1 = new ItemSlot();
            myItem1.ItemName = "item1";
            myItem1.Rarity = ItemRarity.Rare;

            ItemSlot myItem2 = myItem1;
            myItem2.ItemName = "item2";
            myItem2.Rarity = ItemRarity.Legendary;

            Console.WriteLine(myItem1);
            Console.WriteLine(myItem2);

            Console.WriteLine((int)ItemRarity.Epic);

            CheckRarity("Rare");
            CheckRarity("Mythic");
        }
    }
}
