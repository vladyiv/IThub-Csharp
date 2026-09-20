using System;
using System.Collections.Generic;
using System.Text;

namespace _10_ExplicitInterfaceMember
{
    interface IMeleeAttacker { int GetDamage(); }
    interface IMagicAttacker { int GetDamage(); }
    interface IStatBlock { int Health { get; } }
    interface IInventory { string this[int slot] { get; } }

    internal class Hero : IMeleeAttacker, IMagicAttacker, IStatBlock, IInventory
    {
        private readonly int health;
        private readonly List<string> inventory = new();
        public Hero(int health)
        {
            this.health = health;
        }
        public void AddToInventory(string item)
        {
            inventory.Add(item);
        }
        string IInventory.this[int slot] => inventory[slot];

        int IMeleeAttacker.GetDamage() => health / 2;
        int IMagicAttacker.GetDamage() => inventory.Count * 10;
        int IStatBlock.Health => health;
    }
}