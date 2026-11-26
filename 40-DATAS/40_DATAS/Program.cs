namespace _40_DATAS
{
    internal class Program
    {
        public static List<byte[]> list = new List<byte[]>();
        static void Main(string[] args)
        {           

            Console.WriteLine("Создаём много мелких объектов:");
            GCMethods.LotsOfSmallObjects();
            
            Console.WriteLine("Создаём немного больших объектов:");
            GCMethods.FewBigObjects();
            
            Console.WriteLine("Заполняем лист большими объектами:");            
            GCMethods.FillList(list);


            GCMemoryInfo info = GC.GetGCMemoryInfo();
            Console.WriteLine($"Размер кучи: {info.HeapSizeBytes / 1024} Кб");
        }
    }
}
