### Тема LXP: "КТ №11 Реализация интерфейсов"

#### Вариант 2. Зоопарк

1. IAnimal { string Name { get; } void MakeSound(); } — базовый интерфейс.
2. ITrainable : IAnimal { string Train(); } — расширяющий интерфейс, возвращающий результат обучения трюку.
3. Реализуйте Lion, реализующий только IAnimal.
4. Реализуйте Dog и Dolphin, реализующие ITrainable (а значит, и IAnimal).
5. Соберите всех животных в List<IAnimal>, обойдите в цикле: выведите имя и звук каждого, а для тех, что дополнительно реализуют ITrainable (проверка через is), дополнительно выведите результат Train().


| Элемент | Ожидаемое поведение в цикле |
| :--- | :--- |
| Lion | выводится Name и MakeSound(); Train() не вызывается |
| Dog | выводится Name, MakeSound() и дополнительно Train() |
| Dolphin | выводится Name, MakeSound() и дополнительно Train() |

<img width="1632" height="584" alt="Снимок экрана 2026-09-20 в 19 01 42" src="https://github.com/user-attachments/assets/eda6f890-33ac-4fac-9a81-001f27430ded" />
