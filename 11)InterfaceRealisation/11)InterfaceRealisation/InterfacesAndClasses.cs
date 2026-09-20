using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Xml.Linq;

namespace _11_InterfaceRealisation
{
    interface IAnimal { string Name { get; } void MakeSound(); }
    interface ITrainable : IAnimal { string Train(); }

    internal class Lion : IAnimal
    {   public string name { get; }
        public void MakeSound() => Console.WriteLine($"Лев {name} рычит!");
        public Lion(string name) => this.name = name;
        string IAnimal.Name => name;
    }

    internal class Dog : ITrainable
    {
        public string name { get; }
        public string Train() => $"Собака {name} выполняет трюк.";
        public void MakeSound() => Console.WriteLine($"Собака {name} лает!");
        public Dog(string name) => this.name = name;
        string IAnimal.Name => name;
    }

    internal class Dolphin : ITrainable
    {
        public string name { get; }
        public string Train() => $"Дельфин {name} выполняет трюк.";
        public void MakeSound() => Console.WriteLine($"Дельфин {name} издаёт звуки дельфина!");
        public Dolphin(string name) => this.name = name;
        string IAnimal.Name => name;
    }
}
