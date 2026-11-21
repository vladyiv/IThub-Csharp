namespace _40_DATAS
{
    internal class Program
    {
        public static List<byte[]> list = new List<byte[]>();
        static void Main(string[] args)
        {
            long allocBefore = GC.GetTotalAllocatedBytes();
            int beforeGen0 = GC.CollectionCount(0);
            int beforeGen2 = GC.CollectionCount(2);

            Console.WriteLine("Создаём много мелких объектов:");
            GCMethods.LotsOfSmallObjects();
            Console.WriteLine("Создаём немного больших объектов:");
            GCMethods.FewBigObjects();
            Console.WriteLine("Заполняем лист большими объектами:");
            GCMethods.FillList(list);

            int afterGen0 = GC.CollectionCount(0);
            int afterGen2 = GC.CollectionCount(2);
            long allocAfter = GC.GetTotalAllocatedBytes();

            Console.WriteLine("Итоги:");
            Console.WriteLine($"Всего аллоцировано байт: {allocAfter - allocBefore}");
            Console.WriteLine($"Всего сборок Gen0 добавилось: {afterGen0 - beforeGen0}");
            Console.WriteLine($"Всего сборок Gen2 добавилось: {afterGen2 - beforeGen2}");

            GCMemoryInfo info = GC.GetGCMemoryInfo();
            Console.WriteLine($"Размер кучи: {info.HeapSizeBytes / 1024} Кб");
        }
    }
}
