using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OperatorsOverloading
{
    internal class Vector2D
    {
        public double X, Y;

        public Vector2D(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Vector2D operator +(Vector2D a, Vector2D b) => new Vector2D(a.X + b.X, a.Y + b.Y); // сложение
        public static Vector2D operator -(Vector2D a, Vector2D b) => new Vector2D(a.X - b.X, a.Y - b.Y); // вычитание
        public static Vector2D operator -(Vector2D v) => new Vector2D(-v.X, -v.Y); // унарный минус
        public static Vector2D operator *(Vector2D v, double scalar) => new Vector2D(Math.Round(v.X * scalar, 2), Math.Round(v.Y * scalar, 2)); // умножение на число
        public static Vector2D operator *(double scalar, Vector2D v) => v*scalar;
        public override string ToString() => $"Вектор с координатами ({this.X}; {this.Y})";
    }
}
