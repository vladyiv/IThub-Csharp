namespace _35_LINQIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passingGrade = 60;
            int n = 95;

            List<Student> students = new List<Student>
            {
                new Student("Влада", "Язык программирования С#", 100),
                new Student("Дарья", "Язык программирования С#", 99),
                new Student("Олег", "Тестирование. Проектирование тестов", 40),
                new Student("Софья", "Тестирование. Проектирование тестов", 75),
                new Student("Егор", "Тестирование. Проектирование тестов", 59),
                new Student("Юлия", "Язык программирования С#", 88),
                new Student("Данила", "Тестирование. Проектирование тестов", 0),
                new Student(null, null, 80)
            };

            IEnumerable<string> sortedStudents = students
                .Where(s => s.Points >= passingGrade)
                .OrderByDescending(s => s.Points)
                .Select(s => s.ToString());

            Console.WriteLine("Сортировка по проходному баллу по убыванию:");
            foreach (string student in sortedStudents) Console.WriteLine(student);
            Console.WriteLine();

            bool highGrades = students.Any(s => s.Points >= n);
            Console.WriteLine($"Существуют ли студенты, набравшие {n} баллов? -> {highGrades}");
            Console.WriteLine();
            
            bool allPassed = students.All(s => s.Points >= passingGrade);
            Console.WriteLine($"Все ли набрали проходной балл ({passingGrade})? -> {allPassed}");
            Console.WriteLine();

            IEnumerable<string> sortedCourses = students
                .Where(s => s.Course == "Тестирование. Проектирование тестов")
                .OrderBy(s => s.Name)
                .Select(s => s.ToString());

            Console.WriteLine("Сортировка по предмету в алфавитном порядке:");
            foreach (string student in sortedCourses) Console.WriteLine(student);
            Console.WriteLine();
        }
    }
}


//| Действие | Ожидаемый результат |
//| цепочка Where → OrderByDescending → Select | список строк сдавших студентов, по убыванию баллов |
//| All(s => s.Score >= 60) | false, если хотя бы один не сдал |
//| Any(s => s.Score >= 95) | true/false в зависимости от данных |

