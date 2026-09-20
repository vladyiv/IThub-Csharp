namespace _10_ExplicitInterfaceMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero(100);
            hero.AddToInventory("Зелье");
            hero.AddToInventory("Посох");

            Console.WriteLine("Слот инвентаря с индексом 0: " + ((IInventory)hero)[0]);
            Console.WriteLine("Урон мечом: " + ((IMeleeAttacker)hero).GetDamage());
            Console.WriteLine("Урон магией: " + ((IMagicAttacker)hero).GetDamage());
            Console.WriteLine(((IStatBlock)hero).Health);
        }
    }
}
