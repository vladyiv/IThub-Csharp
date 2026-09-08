// Вариант 2. GameInventory (инвентарь персонажа)

namespace _2_IndexerOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventory = new GameInventory(5);
            inventory[0] = "Меч";
            inventory[2] = "Зелье";
            inventory[4] = "Зелье";

            Console.WriteLine(inventory[0]);       // Меч
            Console.WriteLine(inventory["Зелье"]); // 2
            Console.WriteLine(inventory["Щит"]);   // 0
            Console.WriteLine(inventory);
            Console.WriteLine(inventory[10]);

            Console.ReadLine();
        }
    }
}
