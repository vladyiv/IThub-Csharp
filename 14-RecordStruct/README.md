### Тема LXP: «Контрольная точка №14 — record и record struct»

#### Вариант 2. Vector3

1. public record Vector3(double X, double Y, double Z) с дополнительным вычисляемым свойством Length (через Math.Sqrt(XX + YY + Z*Z)), добавленным в тело записи помимо позиционных параметров.
2. Создайте два экземпляра Vector3 с одинаковыми координатами и продемонстрируйте, что == возвращает true.
3. Используйте with, чтобы создать копию с изменённым Z, и выведите оригинал и копию, доказав, что оригинал не изменился (включая то, что Length пересчитывается для копии).
4. Продеконструируйте Vector3 в переменные x, y, z.
5. Объявите public record struct Vector3Struct(double X, double Y, double Z) и продемонстрируйте, что X можно изменить напрямую — в отличие от Vector3.X.


| Действие | Ожидаемый результат |
| :--- | :--- |
| `new Vector3(1, 2, 2) == new Vector3(1, 2, 2)` | `True` |
| `new Vector3(1, 2, 2).Length` | `3` |
| `vector with { Z = 0 }` | новый объект с пересчитанным `Length`; оригинал не изменился |
| `var (x, y, z) = vector;` | `x`, `y`, `z` получают значения координат |
| `vector3Struct.X = 99;` напрямую | компилируется и работает (в отличие от `Vector3.X`) |


<img width="1400" height="689" alt="Снимок экрана 2026-09-29 в 13 54 17" src="https://github.com/user-attachments/assets/8b12099a-acdb-43ba-8680-97930212db01" />

<img width="1155" height="249" alt="Снимок экрана 2026-09-29 в 13 51 09" src="https://github.com/user-attachments/assets/ee4eb2eb-b812-42a4-b042-8ad65a30e6f8" />

<img width="1813" height="864" alt="Снимок экрана 2026-09-29 в 13 13 08" src="https://github.com/user-attachments/assets/04880bb2-c160-42bf-8768-307ffaec593e" />


