### Тема LXP: «Контрольная точка №14 — record и record struct»

#### Вариант 2. Vector3

1. public record Vector3(double X, double Y, double Z) с дополнительным вычисляемым свойством Length (через Math.Sqrt(XX + YY + Z*Z)), добавленным в тело записи помимо позиционных параметров.
2. Создайте два экземпляра Vector3 с одинаковыми координатами и продемонстрируйте, что == возвращает true.
3. Используйте with, чтобы создать копию с изменённым Z, и выведите оригинал и копию, доказав, что оригинал не изменился (включая то, что Length пересчитывается для копии).
4. Продеконструируйте Vector3 в переменные x, y, z.
5. Объявите public record struct Vector3Struct(double X, double Y, double Z) и продемонстрируйте, что X можно изменить напрямую — в отличие от Vector3.X.

<img width="1711" height="711" alt="Снимок экрана 2026-09-29 в 13 16 33" src="https://github.com/user-attachments/assets/435a8dab-8550-40be-9079-a05489e5a7cf" />

<img width="782" height="400" alt="Снимок экрана 2026-09-27 в 21 39 31" src="https://github.com/user-attachments/assets/4286cee3-d4d8-4434-b13f-d7c3e01a732c" />

<img width="1813" height="864" alt="Снимок экрана 2026-09-29 в 13 13 08" src="https://github.com/user-attachments/assets/04880bb2-c160-42bf-8768-307ffaec593e" />


