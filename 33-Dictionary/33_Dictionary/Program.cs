namespace _33_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stock = new Dictionary<string, int>()
            {
                { "Яблоки (кг)", 100 },
                { "Хлеб (батон)",  20 },
                { "Чай (упаковка)", 150 },
                { "Яйца (упаковка)", 50 }
            };

            void Delivery(string product, int amount)
            {
                if (stock.TryGetValue(product, out int currentAmount)) stock[product] += amount;
                else stock[product] = amount;
                Console.WriteLine($"Поставка! Продукт: {product}, количество: {amount}.");
            }

            void RemoveEmpty(string product)
            {
                if (stock[product] == 0) stock.Remove(product);
            }

            void Sell(string product, int amount)
            {
                if ((stock.TryGetValue(product, out int currentAmount)) && stock[product] >= amount)
                {
                    stock[product] -= amount;
                    Console.WriteLine($"Продано {amount} единиц товара {product}!");
                    RemoveEmpty(product);
                }
                else Console.WriteLine("Товара недостаточно или он отсутствует на складе!");
            }

            void PrintStock()
            {
                Console.WriteLine();
                foreach (KeyValuePair<string, int> kvp in stock)
                {
                    Console.WriteLine($"Продукт: {kvp.Key}, количество: {kvp.Value};");
                }
                Console.WriteLine();
            }

            PrintStock();

            Console.WriteLine("Завезли новый товар");
            Delivery("Печенье (упаковка)", 30);
            PrintStock();

            Console.WriteLine("Завезли существующий товар");
            Delivery("Печенье (упаковка)", 70);
            PrintStock();

            Console.WriteLine("Продали весь имеющийся товар");
            Sell("Чай (упаковка)", 150);
            PrintStock();

            Console.WriteLine("Продали имеющийся товар");
            Sell("Яйца (упаковка)", 30);
            PrintStock();

            Console.WriteLine("Попытались продать товар, которого недостаточно");
            Sell("Яблоки (кг)", 200);
            Console.WriteLine();

            Console.WriteLine("Попытались продать несуществующий товар");
            Sell("Груши (кг)", 200);
        }
    }
}


//| Действие | Ожидаемый результат |
//| поступление нового товара | новая запись с указанным количеством |
//| поступление уже существующего товара | количество увеличилось, а не создалась вторая запись |
//| продажа больше, чем есть на складе | сообщение об ошибке, без исключения и без отрицательного количества |
//| количество товара стало 0 | запись удалена из словаря |

