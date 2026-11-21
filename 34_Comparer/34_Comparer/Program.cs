namespace _34_Comparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee(1, "Влада", 0, "01.09.2024"),
                new Employee(5, "Дарья", 1000000, "9.11.2026"),
                new Employee(3, "Алина", 750000, "01.01.2026"),
                new Employee(4, "Андрей", 500000, "02.02.2020"),
                new Employee(2, null, 50000, null)
            };

            void PrintEmployees()
            {
                foreach (Employee employee in employees) Console.WriteLine(employee);
                Console.WriteLine();
            }

            Console.WriteLine("Сортировка по зарплате (по умолчанию):");
            employees.Sort();
            PrintEmployees();

            Console.WriteLine("Сортировка по дате приёма на работу (HireDateComparer):");
            employees.Sort(new HireDateComparer());
            PrintEmployees();

            Console.WriteLine("Сортировка по имени (лямбда):");
            employees.Sort((Employee a, Employee b) => a.Name.CompareTo(b.Name));
            PrintEmployees();
;
            Console.WriteLine("Сортировка по ID (лямбда):");
            employees.Sort((Employee a, Employee b) => a.ID.CompareTo(b.ID));
            PrintEmployees();
        }
    }
}
