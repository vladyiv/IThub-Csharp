namespace _11_1_InterfaceRealisation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(5);
            IShape rectangle = new Rectangle(2, 4);
            IDrawable triangle = new Triangle(4);

            List<IShape> shapes = new() { circle, rectangle, triangle };
            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Площадь фигуры: {shape.Area()}.");
                Console.WriteLine($"Периметр фигуры: {shape.Perimeter()}.");
                if (shape is IDrawable drawable)
                {
                    Console.WriteLine(drawable.Draw());                    
                }
                Console.WriteLine();
            }
        }
    }
}