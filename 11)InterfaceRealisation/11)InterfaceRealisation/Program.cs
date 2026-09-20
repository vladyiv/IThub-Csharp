namespace _11_InterfaceRealisation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Бонифаций");
            Dog dog = new Dog("Шарик");
            Dolphin dolphin = new Dolphin("Долли");

            List<IAnimal> animals = new() { lion, dog, dolphin };
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine("Животное по имени " + animal.Name);
                animal.MakeSound();
                if (animal is ITrainable trainable)
                    Console.WriteLine(trainable.Train());
                Console.WriteLine();
            }
        }
    }
}