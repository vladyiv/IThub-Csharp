namespace _34_Comparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Влада", 0, "01.09.2026"),
                new Employee("Дарья", 1000000, "10.11.2026"),
                new Employee("Алина", 750000, "01.01.2024"),
                new Employee("Андрей", 500000, "02.02.2020")
            };

            Console.WriteLine("Сортировка по зарплате (по умолчанию):");
            employees.Sort();
            foreach (Employee employee in employees) Console.WriteLine(employee);
            Console.WriteLine();

            Console.WriteLine("Сортировка по дате приёма на работу (HireDateComparer):");
            employees.Sort(new HireDateComparer());
            foreach (Employee employee in employees) Console.WriteLine(employee);
            Console.WriteLine();

            Console.WriteLine("Сортировка по имени (лямбда):");
            employees.Sort((Employee a, Employee b) => a.Name.CompareTo(b.Name));
            foreach (Employee employee in employees) Console.WriteLine(employee);         
        }
    }
}
