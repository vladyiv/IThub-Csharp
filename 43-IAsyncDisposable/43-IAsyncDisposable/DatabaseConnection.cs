using System;
using System.Collections.Generic;
using System.Text;

namespace _43_IAsyncDisposable
{
    internal class DatabaseConnection : IDisposable, IAsyncDisposable
    {
        private bool disposed;
        List<string>? requestsLog = new();
        private int connectionId;
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            disposed = true;
            if (disposing)
            {
                Console.WriteLine("Синхронная очистка управляемых ресурсов");
            }
            connectionId = 0;
            Console.WriteLine("Освобождение нативного ресурса");
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore().ConfigureAwait(false);
            Dispose(disposing: false);
            GC.SuppressFinalize(this);
        }
        protected virtual async ValueTask DisposeAsyncCore()
        {
            if (!disposed)
            {
                await Task.Delay(10);
                Console.WriteLine("Асинхронная очистка завершена");
            }
            requestsLog?.Clear();
        }
        ~DatabaseConnection()
        {
            Console.WriteLine("Финализатор сработал!");
            Dispose(disposing: false);
        }

        public void WorkWithDB()
        {
            Console.Write("Введите адрес порта (ID подключения): ");
            connectionId = Logic.SafeInputInt();
            requestsLog.Add($"[{connectionId}] {DateTime.Now} выполнено подключение к базе данных");
            while (true)
            {
                Console.WriteLine("┌─ Выберите действие  ────────────────────────────┐");
                Console.WriteLine("|  1 - Сделать запрос                             |");
                Console.WriteLine("|  2 - Посмотреть логи                            |");
                Console.WriteLine("|  Чтобы отключиться, введите любой другой символ |");
                Console.WriteLine("└─────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        string query = Logic.SafeInputString();
                        requestsLog.Add($"[{connectionId}] {DateTime.Now} {query}");
                        Console.WriteLine($"[{connectionId}] {DateTime.Now} Выполнен запрос: {query}");
                        break;

                    case "2":
                        foreach (string log in requestsLog) Console.WriteLine(log);
                        break;
                    
                    default:
                        Console.WriteLine("Отключение...");
                        return;
                }
            }
        } 
    }
}
