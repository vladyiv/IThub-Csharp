using System;
using System.Collections.Generic;
using System.Text;

namespace _12_EnumAndStructures
{
    public enum ItemRarity { Common = 0, Rare = 5, Epic = 15, Legendary = 30 };

    public struct ItemSlot
    {
        public string ItemName;
        public ItemRarity Rarity;

        public override string ToString() => $"Предмет: {ItemName}, редкость: {Rarity}, бонус: +{(int)Rarity}.";
    }
}

//enum ItemRarity { Common, Rare, Epic, Legendary } — редкость предмета.
//struct ItemSlot { string ItemName; ItemRarity Rarity; } — с методом, который возвращает бонус к характеристике в зависимости от Rarity(например, Common = +0, Rare = +5, Epic = +15, Legendary = +30).
//Переопределите ToString(), чтобы вывести название предмета, редкость и бонус.
//Продемонстрируйте копирование: создайте слот, скопируйте в другую переменную, измените редкость копии и выведите обе — убедитесь, что оригинал не изменился.
//Продемонстрируйте Enum.TryParse<ItemRarity> на строке, введённой как константа в коде (и на корректном, и на некорректном значении).
