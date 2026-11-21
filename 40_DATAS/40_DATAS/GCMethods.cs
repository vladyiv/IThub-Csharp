using System;
using System.Collections.Generic;
using System.Text;

namespace _40_DATAS
{
    internal class GCMethods
    {
        public static void LotsOfSmallObjects()
        {
            long allocBefore = GC.GetTotalAllocatedBytes();
            int beforeGen0 = GC.CollectionCount(0);
            int beforeGen2 = GC.CollectionCount(2);

            for (int i = 0; i < 100_000; i++)
            {
                var temp = new byte[100];
                _ = temp;
            }
            int afterGen0 = GC.CollectionCount(0);
            int afterGen2 = GC.CollectionCount(2);

            long allocAfter = GC.GetTotalAllocatedBytes();
            Console.WriteLine($"Аллоцировано байт: {allocAfter - allocBefore}");
            Console.WriteLine($"Сборок Gen0 добавилось: {afterGen0 - beforeGen0}");
            Console.WriteLine($"Сборок Gen2 добавилось: {afterGen2 - beforeGen2}");
            GCMemoryInfo info = GC.GetGCMemoryInfo();
            Console.WriteLine($"Размер кучи: {info.HeapSizeBytes / 1024} Кб");
            Console.WriteLine();
        }
        public static void FewBigObjects()
        {
            long allocBefore = GC.GetTotalAllocatedBytes();
            int beforeGen0 = GC.CollectionCount(0);
            int beforeGen2 = GC.CollectionCount(2);

            for (int i = 0; i < 10; i++)
            {
                var temp = new byte[100_000];
                _ = temp;
            }
            int afterGen0 = GC.CollectionCount(0);
            int afterGen2 = GC.CollectionCount(2);

            long allocAfter = GC.GetTotalAllocatedBytes();
            Console.WriteLine($"Аллоцировано байт: {allocAfter - allocBefore}");
            Console.WriteLine($"Сборок Gen0 добавилось: {afterGen0 - beforeGen0}");
            Console.WriteLine($"Сборок Gen2 добавилось: {afterGen2 - beforeGen2}");
            GCMemoryInfo info = GC.GetGCMemoryInfo();
            Console.WriteLine($"Размер кучи: {info.HeapSizeBytes / 1024} Кб");
            Console.WriteLine();
        }
        public static void FillList(List<byte[]> list)
        {
            long allocBefore = GC.GetTotalAllocatedBytes();
            int beforeGen0 = GC.CollectionCount(0);
            int beforeGen2 = GC.CollectionCount(2);

            for (int i = 0; i < 10; i++)
            {
                list.Add(new byte[1_000_000]);
            }

            int afterGen0 = GC.CollectionCount(0);
            int afterGen2 = GC.CollectionCount(2);

            long allocAfter = GC.GetTotalAllocatedBytes();
            Console.WriteLine($"Аллоцировано байт: {allocAfter - allocBefore}");
            Console.WriteLine($"Сборок Gen0 добавилось: {afterGen0 - beforeGen0}");
            Console.WriteLine($"Сборок Gen2 добавилось: {afterGen2 - beforeGen2}");
            GCMemoryInfo info = GC.GetGCMemoryInfo();
            Console.WriteLine($"Размер кучи: {info.HeapSizeBytes / 1024} Кб");
            Console.WriteLine();
        }
    }
}
