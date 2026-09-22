using System;
using System.Collections.Generic;
using System.Text;

namespace _11_1_InterfaceRealisation
{
    interface IShape { double Area(); double Perimeter(); }
    interface IDrawable : IShape { string Draw(); }
    internal class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius) => Radius = radius;

        public double Area() => Math.Round(Math.PI * Radius * Radius, 2);
        public double Perimeter() => Math.Round(2 * Math.PI * Radius);
    }
    internal class Rectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Area() => Math.Round(Width * Height, 2);
        public double Perimeter() => Math.Round(2 * (Width + Height), 2);
    }
    internal class Triangle : IDrawable
    {
        public double Side { get; }
        public Triangle(double side) => Side = side;
        public string Draw() => "\u25B2";
        public double Area() => Math.Round(Side * Side * Math.Sqrt(3) / 4, 2);
        public double Perimeter() => Side * 3;
    }


}