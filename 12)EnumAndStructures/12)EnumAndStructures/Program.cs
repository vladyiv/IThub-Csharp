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
            Console.WriteLine("Слот до изменения копии: " + myItem1);
            myItem2.ItemName = "item2";
            myItem2.Rarity = ItemRarity.Legendary;

            Console.WriteLine("Слот после изменения копии: " + myItem1);
            Console.WriteLine("Изменённая копия: " + myItem2);
            Console.WriteLine();

            Console.WriteLine("Бонус эпического предмета: +" + (int)ItemRarity.Epic);

            CheckRarity("Rare");
            CheckRarity("Mythic");
        }
    }
}
