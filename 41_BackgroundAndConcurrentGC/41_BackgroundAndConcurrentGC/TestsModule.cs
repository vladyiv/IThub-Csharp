using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _41_BackgroundAndConcurrentGC
{
    internal class TestsModule
    {
        static List<byte[]> _longLived = new List<byte[]>();
        static List<byte[]> _heavyLoh = new List<byte[]>();

        public static void LongLived(int amount, int size)
        {
            List<byte[]> longLived = new List<byte[]>();
            for (int i = 0; i < amount; i++)
            {
                longLived.Add(new byte[size]);
            }
            _longLived.AddRange(longLived);
        }

        public static void HeavyLoh(int amount, int size)
        {
            List<byte[]> heavyLoh = new List<byte[]>();            
            for (int i = 0; i < amount; i++)
            {
                heavyLoh.Add(new byte[size]);
            }
            _heavyLoh.AddRange(heavyLoh);
        }

        public static void ShortLived(int amount, int size)
        {
            Console.WriteLine($"Проходим {amount} итераций с new byte[{size}]");
            for (int i = 0; i < amount; i++)
            {
                var b = new byte[size];
            }
        }

        public static void CheckGen2Block()
        {
            var sw = Stopwatch.StartNew();
            GC.Collect(2, GCCollectionMode.Forced, blocking: true);
            sw.Stop();
            Console.WriteLine($"Блокирующая Gen2: {sw.Elapsed.TotalMilliseconds:F3} мс");
        }

        public static void TestResult(Action<int, int> action, int n, int m)
        {
            int gen0before = GC.CollectionCount(0);
            int gen1before = GC.CollectionCount(1);
            int gen2before = GC.CollectionCount(2);
            Stopwatch sw = Stopwatch.StartNew();

            action(n, m);

            sw.Stop();

            Console.WriteLine($"Gen0 сборок добавилось: {GC.CollectionCount(0) - gen0before}");
            Console.WriteLine($"Gen1 сборок добавилось: {GC.CollectionCount(1) - gen1before}");
            Console.WriteLine($"Gen2 сборок добавилось: {GC.CollectionCount(2) - gen2before}");
            Console.WriteLine($"Органическая аллокация: {sw.Elapsed.TotalMilliseconds:F3} мс");
            Console.WriteLine();
        }

        public static void Clear()
        {
            _longLived = new List<byte[]>();
            _heavyLoh = new List<byte[]>();
            Console.WriteLine("Ссылки очищены!");
        }
    }
}
