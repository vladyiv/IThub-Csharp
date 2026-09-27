### Тема LXP: «Контрольная точка №14 — record и record struct»

#### Вариант 2. Vector3

1. public record Vector3(double X, double Y, double Z) с дополнительным вычисляемым свойством Length (через Math.Sqrt(XX + YY + Z*Z)), добавленным в тело записи помимо позиционных параметров.
2. Создайте два экземпляра Vector3 с одинаковыми координатами и продемонстрируйте, что == возвращает true.
3. Используйте with, чтобы создать копию с изменённым Z, и выведите оригинал и копию, доказав, что оригинал не изменился (включая то, что Length пересчитывается для копии).
4. Продеконструируйте Vector3 в переменные x, y, z.
5. Объявите public record struct Vector3Struct(double X, double Y, double Z) и продемонстрируйте, что X можно изменить напрямую — в отличие от Vector3.X.

<img width="1479" height="841" alt="Снимок экрана 2026-09-27 в 21 38 11" src="https://github.com/user-attachments/assets/a783499e-bd39-437d-ade0-9767965dfee8" />

<img width="782" height="400" alt="Снимок экрана 2026-09-27 в 21 39 31" src="https://github.com/user-attachments/assets/4286cee3-d4d8-4434-b13f-d7c3e01a732c" />

<img width="1667" height="657" alt="Снимок экрана 2026-09-27 в 21 41 21" src="https://github.com/user-attachments/assets/e23b19f9-edbb-42e6-a353-2cb7ff0fd986" />


