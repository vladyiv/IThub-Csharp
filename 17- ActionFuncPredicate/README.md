### Тема LXP: "КТ №17 Делегаты Action<T>, Func<T>, Predicate<T>"
#### Вариант 2. Проверка имён пользователей

1. List<string> usernames — список имён пользователей.
2. Action<string> welcome — выводит приветственное сообщение для каждого имени.
3. Func<string, string> normalize — приводит имя к нижнему регистру (или другому каноническому виду).
4. Predicate<string> isTooShort — проверяет, что длина имени меньше минимально допустимой (например, 3 символа), используйте через List<string>.Find.
5. Продемонстрируйте, что одноимённая логика, оформленная как Func<string, bool>, не присваивается напрямую переменной типа Predicate<string>.


| Действие | Ожидаемый результат |
| :--- | :--- |
| `Action<string>` для каждого элемента | выводит приветствие для каждого имени |
| `normalize("Светлана")` | `"светлана"` |
| `usernames.Find(isTooShort)` | `"Al"` — первое имя короче 3 символов |

<img width="1747" height="925" alt="Снимок экрана 2026-10-03 в 17 04 52" src="https://github.com/user-attachments/assets/f9b65b9c-3083-4f0c-91f1-d3b6ce66b1db" />

<img width="1183" height="282" alt="Снимок экрана 2026-10-03 в 16 53 23" src="https://github.com/user-attachments/assets/d9910eff-125d-4f3b-93fa-718a7528e7f8" />

<img width="665" height="453" alt="Снимок экрана 2026-10-03 в 17 06 05" src="https://github.com/user-attachments/assets/cbd491ac-4d39-4f05-ae48-b61875e89718" />
