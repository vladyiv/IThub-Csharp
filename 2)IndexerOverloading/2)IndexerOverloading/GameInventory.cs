using System;
using System.Collections.Generic;
using System.Text;

namespace _2_IndexerOverloading
{
    internal class GameInventory
    {
        private readonly string[] slots; // список слотов для хранения предметов, доступный только для чтения
        public GameInventory(int slotsCount)
        {
            slots = new string[slotsCount]; // определяем размер в зависимости от ввода пользователя
        }

        public string this[int slot]
        {
            get
            {
                try
                {
                    return slots[slot];
                }
                catch (IndexOutOfRangeException)
                {
                    ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException();
                    throw ex;
                }
            }

            set => slots[slot] = value;
        }

        public int itemSlots(string itemName) // сделала функцию для подсчёта количества слотов с одним предметом
        {
            int count = 0;
            foreach (string slot in slots)
            {
                if (slot == itemName)
                {
                    count++;
                }
            }
            return count;
        }

        public int this[string itemName]
        {
            get => itemSlots(itemName);
        }

        //public int this[string itemName] => _items.Count(item => item == itemName); <-- подсмотрела, как вывести количество слотов без отдельной функции с циклом

        public override string ToString()
        {
            string[] output = new string[slots.Length];
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i] == null)
                {
                    output[i] = "-"; // вместо незаполненных слотов будет выводиться -
                }
                else
                {
                    output[i] = slots[i]; // остальное выведется как есть
                }
            }
            return "Items: " + String.Join(", ", output);
        }

        //public override string ToString() <-- подсмотрела реализацию без цикла
        //{
        //    return "Items: " + string.Join(", ", slots.Select(slot => slot ?? "-"));
        //}

    }
}