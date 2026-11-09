namespace _35_LINQIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passingGrade = 50;

            List<Student> students = new List<Student>
            {
                new Student("Влада", 100),
                new Student("Дарья", 99),
                new Student("Олег", 49),
                new Student("Александр", 30),
                new Student("Юлия", 55),
                new Student("Софья", 75)
            };

            IEnumerable<string> sortedStudents = students
                .Where(s => s.Points >= passingGrade)
                .OrderByDescending(s => s.Points)
                .Select(s => s.ToString());

            Console.WriteLine("Сортировка по проходному баллу по убыванию баллов:");
            foreach (string student in sortedStudents) Console.WriteLine(student);
            Console.WriteLine();

            bool highGrades = students.Any(s =>  s.Points >= 70);
            Console.WriteLine("Существуют ли студенты, набравшие 70 баллов? " + highGrades);
            Console.WriteLine();
            
            bool allPassed = students.All(s => s.Points >= passingGrade);
            Console.WriteLine("Все ли набрали проходной балл? " + allPassed);
        }
    }
}
