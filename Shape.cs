namespace task8
{
    internal abstract class Shape
    {
        public abstract double GetArea();

        public void Display()
        {
            Console.WriteLine("This is a shape");
        }
    }

    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    internal class Shape1 : IComparable<Shape1>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shape1(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public int CompareTo(Shape1 other)
        {
            return Area.CompareTo(other.Area);
        }
    }
}