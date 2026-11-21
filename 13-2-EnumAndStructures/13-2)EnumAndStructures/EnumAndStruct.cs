using System;
using System.Collections.Generic;
using System.Text;

namespace _13_2_EnumAndStructures
{
    public enum ItemRarity { Common, Rare, Epic, Legendary }
    public enum ItemSlot { Weapon, Armor, Accessory }
    struct Item {
        public string Name;
        public ItemRarity Rarity;
        public ItemSlot Slot;

        public override string ToString() => $"Предмет {Name}, категория: {Slot}, редкость: {Rarity}.";
    }
}
