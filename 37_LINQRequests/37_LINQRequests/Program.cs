using System.Numerics;

namespace _37_LINQRequests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Влада"),
                new Student("Дарья"),
                new Student("Алина"),
                new Student("Андрей")
            };
            List<Enrollment> enrollment = new List<Enrollment>
            {
                new Enrollment(1, "Язык программирования C#", 73),
                new Enrollment(1, "Введение в DevSecOps", 45),
                new Enrollment(1, "Тестирование. Проектирование тестов", 59),
                new Enrollment(2, "Администрирование баз данных в MS SQL", 100),
                new Enrollment(2, "Введение в DevSecOps", 100),
                new Enrollment(2, "Язык программирования C#", 50),
                new Enrollment(3, "Введение в DevSecOps", 100),
                new Enrollment(3, "Язык программирования C#", 66),
                new Enrollment(4, "Язык программирования C#", 90),
                new Enrollment(4, "Тестирование. Проектирование тестов", 90),
                new Enrollment(1, "Linux для разработчиков", 55),
                new Enrollment(2, "Linux для разработчиков", 70)
            };

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ────────────────────────────────────────────┐");
                Console.WriteLine("|  1 - Дополнить список студентов                                 |");
                Console.WriteLine("|  2 - Дополнить список дисциплин                                 |");
                Console.WriteLine("|  3 - Вывести список студентов                                   |");
                Console.WriteLine("|  4 - Вывести список дисциплин                                   |");
                Console.WriteLine("|  5 - Вывести сводку зачисления (студент, дисциплина, оценка)    |");
                Console.WriteLine("|  6 - Вывести сводку успеваемости                                |");
                Console.WriteLine("|  (дисциплина, средний балл, количество студентов)               |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ                       |");
                Console.WriteLine("└─────────────────────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        students.FillList(Logic.StudentCreate);
                        break;

                    case "2":
                        enrollment.FillList(Logic.EnrollmentCreate);
                        break;

                    case "3":
                        foreach (Student student in students.OrderBy(s => s.ID)) Console.WriteLine(student);
                        break;

                    case "4":
                        foreach (Enrollment e in enrollment) Console.WriteLine(e);
                        break;

                    case "5":
                        var summaryGrade = students
                            .Join(enrollment, s => s.ID, e => e.StudentID, (s, e) => new { s.ID, s.Name, e.CourseName, e.Grade })
                            .Select(g => new
                            {
                                g.ID,
                                g.Name,
                                g.CourseName,
                                g.Grade
                            })
                            .OrderBy(g => g.ID);

                        foreach (var s in summaryGrade) Console.WriteLine($"Студент: {s.Name}, дисциплина: {s.CourseName}, оценка {s.Grade}/100;");
                        break;

                    case "6":
                        var summaryEnrollment = students
                            .Join(enrollment, s => s.ID, e => e.StudentID, (s, e) => new { e.CourseName, e.StudentID, e.Grade, s.Name })
                            .GroupBy(e => e.CourseName)
                            .Select(g => new
                            {
                                CourseName = g.Key,
                                Average = Math.Round(g.Average(g => g.Grade), 2),
                                Count = g.Count(),
                                StudentNames = string.Join(", ", g.Select(n => n.Name))
                            })
                            .OrderByDescending(g => g.Average);

                        foreach (var student in summaryEnrollment)
                        {
                            Console.WriteLine($"Дисциплина: {student.CourseName}, средний балл: {student.Average}, количество учащихся: {student.Count}, ({student.StudentNames})");
                        }
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
