### Тема LXP: "КТ №10 Явная реализация. Свойства и индексаторы интерфейса"

#### Вариант 2. Hero (герой: атака мечом и магией)

1. IMeleeAttacker { int GetDamage(); } и IMagicAttacker { int GetDamage(); } — одинаковая сигнатура, разный смысл (урон мечом зависит от силы, урон магией — от запаса маны). Реализуйте оба явно в классе Hero.
2. IStatBlock { int Health { get; } } — реализуйте явно: текущее здоровье героя.
3. IInventory { string this[int slot] { get; } } — индексатор, возвращающий название предмета в указанном слоте инвентаря (реализуйте явно или неявно — на ваш выбор).
4. Демонстрационный код: покажите, что hero.GetDamage() напрямую не компилируется, а через ((IMeleeAttacker)hero).GetDamage() и ((IMagicAttacker)hero).GetDamage() — работает и даёт разные значения

| Вызов | Ожидаемый результат |
| :--- | :--- |
| hero.GetDamage() | ошибка компиляции (член недоступен напрямую) |
| ((IMeleeAttacker)hero).GetDamage() | урон мечом, зависящий от силы | 
| ((IMagicAttacker)hero).GetDamage() | урон магией, зависящий от маны, отличается от предыдущего |
| ((IStatBlock)hero).Health | текущее здоровье |

<img width="1069" height="231" alt="Снимок экрана 2026-09-19 в 17 37 47" src="https://github.com/user-attachments/assets/a3bd93f6-357e-468c-9e72-b34c209ff1d5" />

<img width="1302" height="608" alt="Снимок экрана 2026-09-20 в 18 43 03" src="https://github.com/user-attachments/assets/e1180f2f-e755-4adf-b743-28edfe68730d" />
