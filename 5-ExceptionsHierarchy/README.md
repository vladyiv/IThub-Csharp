### Тема LXP: "КТ №5 Иерархия исключений. Конфигурирование состояния"

#### Вариант 2. Трёхуровневая цепочка вызовов
1. Repository.GetUserAge(int userId) — ищет возраст пользователя в Dictionary<int, int> (имитация базы данных); если userId нет — бросает обычный KeyNotFoundException (без оборачивания, это нижний уровень).
2. UserService.GetUserAgeSafe(int userId) — вызывает Repository, ловит KeyNotFoundException, бросает новое InvalidOperationException с понятным сообщением, InnerException и Data["UserId"] = userId.
3. В Main (верхний уровень) поймайте исключение из UserService и распечатайте полную диагностику: сообщение, сообщение InnerException, все записи Data.


| Ввод | Вывод |
| :--- | :--- |
| GetUserAgeSafe(1) (есть в словаре) | возвращает возраст |
| GetUserAgeSafe(999) (нет в словаре) | InvalidOperationException, InnerException типа KeyNotFoundException, Data["UserId"] == 999 |

<img width="1369" height="382" alt="Снимок экрана 2026-09-09 в 20 47 39" src="https://github.com/user-attachments/assets/656330ca-c591-4a55-b8ad-cc9f25f58467" />

<img width="1618" height="779" alt="Снимок экрана 2026-09-09 в 20 48 39" src="https://github.com/user-attachments/assets/d44dffb8-60db-4f96-b36d-18b38b18d786" />

<img width="550" height="82" alt="Снимок экрана 2026-09-09 в 20 50 57" src="https://github.com/user-attachments/assets/5b64095d-3db7-46bb-adb8-e8fdba6e952d" />
