using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueFalseOverloading
{
    internal class Fraction
    {

        public int Numerator, Denominator;

        public int GCD(int a, int b) // поиск НОД по алгоритму Евклида
        {
            a = Math.Abs(a); // чтобы правильно работало с отрицательными числами (не меняло знаки)
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равным нулю!");
            }
            if (denominator < 0)
            {
                this.Numerator = -(numerator / GCD(numerator, denominator));
                this.Denominator = -(denominator / GCD(numerator, denominator));
                return;
            }
            this.Numerator = numerator / GCD(numerator, denominator);
            this.Denominator = denominator / GCD(numerator, denominator);
        }

        public override bool Equals(object obj) => obj is Fraction f && this == f; // проверяем, является ли объект вообще представителем класса Fraction и равен ли он заявленной дроби. должны выполнятся оба условия
        public override int GetHashCode() => HashCode.Combine(Numerator, Denominator);

        // операторы сравнения
        public static bool operator ==(Fraction f1, Fraction f2) => f1.Numerator * f2.Denominator == f2.Numerator * f1.Denominator;
        public static bool operator !=(Fraction f1, Fraction f2) => !(f1 == f2); // лайфхак, чтобы не писать так подробно, как выше
        public static bool operator >(Fraction f1, Fraction f2) => f1.Numerator * f2.Denominator > f2.Numerator * f1.Denominator;
        public static bool operator <(Fraction f1, Fraction f2) => f1.Numerator * f2.Denominator < f2.Numerator * f1.Denominator;
        public static bool operator >=(Fraction f1, Fraction f2) => !(f1 < f2);
        public static bool operator <=(Fraction f1, Fraction f2) => !(f1 > f2);

        // операторы true-false
        public static bool operator true(Fraction f) => f.Numerator != 0;
        public static bool operator false(Fraction f) => f.Numerator == 0;

        // ToString() для красивого вывода
        public override string ToString() => $"Дробь {this.Numerator}/{this.Denominator}";
    }
}
