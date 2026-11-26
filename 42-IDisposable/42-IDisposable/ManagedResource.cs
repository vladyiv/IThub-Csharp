using System;
using System.Collections.Generic;
using System.Text;

namespace _42_IDisposable
{
    internal class ManagedResource : IDisposable
    {
        private bool disposed;
        public ManagedResource() => Console.WriteLine("Открыт");
        public void Dispose()
        {
            if (disposed)
            {
                // Console.WriteLine("Dispose вызван повторно");
                return;
            }
                disposed = true;
            Console.WriteLine("Dispose вызван");
        }
        ~ManagedResource()
        {
            if (!disposed)
            {
                disposed = true;
                Console.WriteLine("Финализатор сработал (забыли Dispose() :( )");
            }
        }
    }
}
