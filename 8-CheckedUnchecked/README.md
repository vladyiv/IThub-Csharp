### Тема LXP: "КТ №8 checked/unchecked. Лучшие практики обработки ошибок"

#### Вариант 1. Калькулятор сумм

1. Метод int SumChecked(int[] numbers) — суммирует массив через checked, перехватывает OverflowException и возвращает int.MaxValue с выводом предупреждения вместо падения программы.
2. Возьмите готовый фрагмент: try { return int.Parse(input); } catch (Exception) { return 0; }. Перепишите его через int.TryParse, без try/catch.

| Вызов | Ожидаемый результат |
| :--- | :--- |
| SumChecked(new[] { 1, 2, 3 }) | 6 | 
| SumChecked(new[] { int.MaxValue, 1 }) | предупреждение в лог, возвращает int.MaxValue |
| int.TryParse("42", out var n) после рефакторинга | n == 42, без исключений |
| int.TryParse("abc", out var n) после рефакторинга | возвращает 0, без исключений |

<img width="1325" height="274" alt="Снимок экрана 2026-09-12 в 18 32 04" src="https://github.com/user-attachments/assets/17560a78-facf-4808-bb2e-c26b68a7214a" />
