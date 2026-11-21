### Тема LXP: "КТ №13 Задание на структуры и перечисления"

#### Вариант 1. Игральная карта

1. enum Suit { Clubs, Diamonds, Hearts, Spades } и enum Rank { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }.
2. struct Card { Suit Suit; Rank Rank; } с переопределённым ToString(), например "Ace of Spades".
3. Создайте массив или список из 5 карт (вручную, без полной генерации колоды).
4. Прочитайте одну карту из коллекции в локальную переменную, измените у копии Rank, и выведите оба значения, доказав, что коллекция не изменилась.
5. Реализуйте разбор строки в Rank через Enum.TryParse — продемонстрируйте на корректном ("King") и некорректном ("Joker") значении.


| Действие | Ожидаемый результат |
| :--- | :--- |
| `cards[0]` (до изменения копии) | например, `"King of Hearts"` |
| копия `cards[0]`, `Rank` копии изменён на `Ace` | копия — `"Ace of Hearts"`, `cards[0]` — без изменений |
| `Enum.TryParse<Rank>("King", out var r)` | `true`, `r == Rank.King` |
| `Enum.TryParse<Rank>("Joker", out var r)` | `false`, без исключения |

<img width="1190" height="735" alt="Снимок экрана 2026-09-20 в 14 12 46" src="https://github.com/user-attachments/assets/45709fcc-5664-4438-8f54-8cdf88e5f889" />
