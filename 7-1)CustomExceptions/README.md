### Тема LXP: "КТ №7 Пользовательские исключения"

#### Вариант 1. BankAccount (банковский счёт)

1. BankingException — базовый класс, наследник Exception, с тремя стандартными конструкторами.
2. InsufficientFundsException : BankingException — свойства RequestedAmount и AvailableBalance (decimal); сообщение генерируется автоматически на основе этих значений.
3. InvalidAccountException : BankingException — свойство AccountId (string); бросается, если номер счёта не состоит ровно из 6 цифр.
4. Класс BankAccount: конструктор BankAccount(string accountId, decimal initialBalance) бросает InvalidAccountException, если accountId не подходит по формату; метод Withdraw(decimal amount) бросает InsufficientFundsException, если amount больше текущего баланса.
5. Демонстрационный код: обработайте список из нескольких операций (создание счетов и снятие средств), перехватывая InsufficientFundsException и InvalidAccountException отдельно (с разными содержательными сообщениями), и BankingException — последним, как общий перехватчик

| Входные данные | Результат |
| :--- | :--- |
| new BankAccount("12345", 1000m) | InvalidAccountException (5 цифр вместо 6) | 
| new BankAccount("123456", 1000m).Withdraw(2000m) | InsufficientFundsException, RequestedAmount == 2000, AvailableBalance == 1000 |
| new BankAccount("123456", 1000m).Withdraw(500m) | баланс становится 500, исключения нет |

<img width="1258" height="654" alt="Снимок экрана 2026-09-11 в 21 17 26" src="https://github.com/user-attachments/assets/e3fc1ea5-8383-4087-a007-61fc943c123c" />
<img width="1187" height="780" alt="Снимок экрана 2026-09-11 в 21 17 43" src="https://github.com/user-attachments/assets/fe106ad3-db87-4a97-b15f-3938c1975b10" />
<img width="1222" height="664" alt="Снимок экрана 2026-09-11 в 21 18 00" src="https://github.com/user-attachments/assets/de13e967-8974-4bc6-8500-2809c20c97f2" />
