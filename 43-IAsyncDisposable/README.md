# КТ №43 Паттерн Dispose. IAsyncDisposable (.NET 10)

### Вариант 1. Соединение с БД (имитация)
1. Класс DatabaseConnection : IDisposable, IAsyncDisposable с:
- управляемым ресурсом — List<string> лог запросов;
- «нативным» ресурсом — имитируется через int connectionId;
2. protected virtual void Dispose(bool disposing) — управляемые при disposing == true, connectionId всегда.
3. Публичный Dispose() с GC.SuppressFinalize(this).
4. Финализатор, вызывающий Dispose(false).
5. DisposeAsync() через DisposeAsyncCore() — имитирует асинхронное закрытие (например, await Task.Delay(10)).
6. Продемонстрируйте оба сценария: using (new DatabaseConnection()) и await using (new DatabaseConnection()).

| Действие | Ожидаемый результат |
| :--- | :--- |
| `using (new DatabaseConnection())` | синхронная очистка: лог + connectionId закрыты |
| `await using (new DatabaseConnection())` | асинхронная очистка: DisposeAsyncCore выполнен, затем нативный хэндл |
| `GC.SuppressFinalize` проверить | финализатор НЕ вызывается после Dispose() — GC.WaitForPendingFinalizers() после явного Dispose тихий |
| финализатор без Dispose (эксперимент) | выводит только нативные ресурсы, НЕ управляемые |

<img width="788" height="983" alt="Снимок экрана 2026-11-22 в 20 12 27" src="https://github.com/user-attachments/assets/6568f3e3-a34a-4b57-91bb-8fdaffb4256c" />
<img width="747" height="533" alt="Снимок экрана 2026-11-22 в 20 13 56" src="https://github.com/user-attachments/assets/7c84e7fc-708e-4e06-9ac9-14bc859866cd" />
<img width="753" height="557" alt="Снимок экрана 2026-11-22 в 20 14 36" src="https://github.com/user-attachments/assets/58be654a-c886-4084-a000-7db655c396a3" />
