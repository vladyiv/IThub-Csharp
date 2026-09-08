# РЕПОЗИТОРИЙ ДЛЯ РАБОТ В РАМКАХ ДИСЦИПЛИНЫ "ЯЗЫК ПРОГРАММИРОВАНИЯ С#"

## Навигация:

#### • ConstructorAndIndexerOverloading — работа с перегрузкой конструкторов и индексаторов (темы LXP: "КТ №1 Перегрузка методов и конструкторов"; "КТ №2 Перегрузка индексаторов");

<img width="2056" height="967" alt="1-2)constructorandindexeroverloading" src="https://github.com/user-attachments/assets/9c900212-f348-48cd-9cc3-67e1c1d37bdb" />

  
#### • IndexerOverloading — перегрузка индексаторов (тема LXP: "КТ №2 Перегрузка индексаторов")

| Ввод | Вывод |
| :--- | :--- |
| inventory[0] | Меч |
| inventory["Зелье"] | 2 |
| inventory["Щит"] | 0 |
| inventory[10] | исключение ArgumentOutOfRangeException |

<img width="1440" height="635" alt="2)indexoverloading" src="https://github.com/user-attachments/assets/5dc537c9-7397-4dd7-b8ae-27ba50bcd427" />


#### • OperatorsOverloading — перегрузка операторов (тема LXP: "КТ №3 Перегрузка операторов")
  
| Ввод | Вывод |
| :--- | :--- |
| v1 + v2 | (4, 6) |
| v1 - v2 | (-2, -2) |
| -v1 | (-1, -2) |
| v1 * 2 | (2, 4) |
| 2 * v1 | (2, 4) |


<img width="1980" height="799" alt="3)operatorsoverloading" src="https://github.com/user-attachments/assets/42f668d0-1b6a-412d-9f8b-f9423851ecac" />

#### • TrueFalseOverloading — перегрузка True и False (тема LXP: "КТ №4 Перегрузка операторов отношения и операторов true - false")

| Ввод | Вывод |
| :--- | :--- |
| f1 == f2 (1/2 и 2/4) | True |
| f1 < f3 (1/2 и 3/4) | True |
| f1.GetHashCode() == f2.GetHashCode() | True |
| if (new Fraction(0, 5)) ... | Не выполняется |
| new Fraction(1, -2) | хранит Numerator = -1, Denominator = 2 |

<img width="1596" height="794" alt="Снимок экрана 2026-09-08 в 13 58 16" src="https://github.com/user-attachments/assets/56768361-0b12-4e26-ab25-57bafc745908" />

