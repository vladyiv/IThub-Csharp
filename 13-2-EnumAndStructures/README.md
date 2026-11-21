### Тема LXP: "КТ №13 Задание на структуры и перечисления"

#### Вариант 2. RPG-предмет

1. enum ItemRarity { Common, Rare, Epic, Legendary } и enum ItemSlot { Weapon, Armor, Accessory }.
2. struct Item { string Name; ItemRarity Rarity; ItemSlot Slot; } с переопределённым ToString(), например "Меч Дракона (Legendary, Weapon)".
3. Создайте массив или список из 5 предметов (вручную).
4. Прочитайте один предмет из коллекции в локальную переменную, измените у копии Rarity, и выведите оба значения, доказав, что коллекция не изменилась.
5. Реализуйте разбор строки в ItemRarity через Enum.TryParse — продемонстрируйте на корректном ("Epic") и некорректном ("Mythic") значении.


| Действие | Ожидаемый результат |
| :--- | :--- |
| `items[0]` (до изменения копии) | например, `"Меч Дракона (Legendary, Weapon)"` |
| копия `items[0]`, `Rarity` копии изменена на `Common` | копия — `"... (Common, Weapon)"`, `items[0]` — без изменений |
| `Enum.TryParse<ItemRarity>("Epic", out var r)` | `true`, `r == ItemRarity.Epic` |
| `Enum.TryParse<ItemRarity>("Mythic", out var r)` | `false`, без исключения |

<img width="1784" height="714" alt="Снимок экрана 2026-09-20 в 16 23 33" src="https://github.com/user-attachments/assets/b60ea474-13f6-4989-b9a9-3b24cd1b4445" />
