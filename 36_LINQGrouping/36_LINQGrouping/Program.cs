using System.IO.Pipes;

namespace _36_LINQGrouping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Томас", 10),
                new Student("Эдвард", 20),
                new Student("Генри", 55),
                new Student("Гордон", 60),
                new Student("Джеймс", 75),
                new Student("Перси", 100),
                new Student("Тоби", 99),
                new Student("Эмили", 90),
            };

            string gradeLetter(int grade)
            {
                switch (grade)
                {
                    case >= 90:
                        return "A";
                    case >= 70:
                        return "B";
                    case >= 50:
                        return "C";
                    case < 50:
                        return "D";
                }
            }

            var byGrade = students
                .GroupBy(s => gradeLetter(s.Points))
                .Select(s => new { Letter = s.Key, Average = Math.Round(s.Average(s => s.Points), 2), Count = s.Count() })
                .OrderBy(s => s.Letter);
            foreach (var student in byGrade) Console.WriteLine($"Оценка: \"{student.Letter}\", количество: {student.Count}, средний балл: {student.Average};");
        }
    }
}
