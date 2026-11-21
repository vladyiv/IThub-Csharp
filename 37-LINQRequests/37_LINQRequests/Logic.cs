using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _37_LINQRequests
{
    internal class Logic
    {
        public static int SafeInputInt()
        {
            int a = 0;
            while (a <= 0)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a <= 0) Console.WriteLine("Число должно быть положительным!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат данных!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Введено слишком большое число!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка! " + e.Message);
                }
            }
            return a;
        }

        public static string SafeInputString()
        {
            string a = "";
            while (a == "")
            {
                a = Console.ReadLine();
                if (a == "") Console.WriteLine("Пустая строка не принимается!");
            }
            return a;
        }
        public static Student StudentCreate()
        {
            Console.Write("Введите имя студента: ");
            string name = Logic.SafeInputString();
            return new Student(name);
        }

        public static Enrollment EnrollmentCreate()
        {
            Console.Write("Введите ID студента: ");
            int studentID = Logic.SafeInputInt();
            Console.Write("Введите название дисциплины: ");
            string courseName = Logic.SafeInputString();
            Console.Write("Введите оценку: ");
            int grade = Logic.SafeInputInt();
            return new Enrollment(studentID, courseName, grade);
        }
    }
}
