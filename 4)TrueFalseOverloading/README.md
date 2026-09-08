#### TrueFalseOverloading — перегрузка True и False (тема LXP: "КТ №4 Перегрузка операторов отношения и операторов true - false")

| Ввод | Вывод |
| :--- | :--- |
| f1 == f2 (1/2 и 2/4) | True |
| f1 < f3 (1/2 и 3/4) | True |
| f1.GetHashCode() == f2.GetHashCode() | True |
| if (new Fraction(0, 5)) ... | Не выполняется |
| new Fraction(1, -2) | хранит Numerator = -1, Denominator = 2 |

<img width="1596" height="794" alt="Снимок экрана 2026-09-08 в 13 58 16" src="https://github.com/user-attachments/assets/56768361-0b12-4e26-ab25-57bafc745908" />
