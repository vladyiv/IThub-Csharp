### Тема LXP: "КТ №15 Паттерн-матчинг: switch expression, is, when"

#### Вариант 2. Исход боя

Метод string BattleOutcome((int attackerHp, int defenderHp) result), возвращающий строку через switch-выражение по кортежу.

1. Паттерн отношения: (<= 0, > 0) → "defender победил".
2. Паттерн отношения: (> 0, <= 0) → "attacker победил".
3. Константный паттерн: (0, 0) → "оба пали".
4. when-условие: когда оба живы, но attackerHp меньше defenderHp более чем в 2 раза → "defender в большом преимуществе".
5. Завершающая ветка _ → "бой продолжается".


| Вход | Ожидаемый результат |
| :--- | :--- |
| `(0, 50)` | `"defender победил"` |
| `(0, 0)` | `"оба пали"` |
| `(10, 30)` | `"defender в большом преимуществе"` |
| `(40, 50)` | результат из ветки `_` |

<img width="1352" height="574" alt="Снимок экрана 2026-10-01 в 09 59 59" src="https://github.com/user-attachments/assets/638fe17a-1fcc-4762-861e-5bdd1c3df5ee" />

<img width="381" height="151" alt="Снимок экрана 2026-10-01 в 10 00 38" src="https://github.com/user-attachments/assets/e4b62070-ffb0-4911-b99c-b5117a99cbec" />
<img width="360" height="143" alt="Снимок экрана 2026-10-01 в 10 00 45" src="https://github.com/user-attachments/assets/ad013afb-08d3-4a61-ba72-49b22aceecb4" />
<img width="409" height="140" alt="Снимок экрана 2026-10-01 в 10 00 56" src="https://github.com/user-attachments/assets/e8865698-9933-459d-bb65-c4cc6fad0dce" />
<img width="373" height="145" alt="Снимок экрана 2026-10-01 в 10 01 05" src="https://github.com/user-attachments/assets/37a2ba14-cc03-4177-a579-08ceb6083f93" />

<img width="1431" height="747" alt="Снимок экрана 2026-10-01 в 10 02 20" src="https://github.com/user-attachments/assets/3cbdc58e-029f-41c5-aab1-74eadd46f108" />


