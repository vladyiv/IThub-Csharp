using System;
using System.Collections.Generic;
using System.Text;

namespace _42_IDisposable
{
    internal class FakeResource
    {
        public FakeResource() => Console.WriteLine("Открыт");
        ~FakeResource() => Console.WriteLine($"Финализатор");
    }
}
