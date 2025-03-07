using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractExample
{
    abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();

    }

    class Rectangle : Shape
    {
        public double Length;
        public double Width;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double GetArea() => Length * Width;
        public override double GetPerimeter() => 2 * (Length + Width);
    }

    class Circle : Shape
    {
        public double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double GetArea() => Math.PI * Radius * Radius;
        public override double GetPerimeter() => 2 * Math.PI * Radius;
    }
    class Triangle : Shape
    {
        public double Base;
        public double Height;
        public double Side1;
        public double Side2;
        public Triangle(double bas, double height, double side1, double side2)
        {
            Base = bas;
            Height = height;
            Side1 = side1;
            Side2 = side2;
        }
        public override double GetArea() => 0.5 * Base * Height;
        public override double GetPerimeter() => Base + Side1 + Side2;
    }
    class Program3
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 20);
            Circle c = new Circle(5);
            Triangle t = new Triangle(10, 5, 5, 5);
            Console.WriteLine("Area of Rectangle: " + r.GetArea());
            Console.WriteLine("Perimeter of Rectangle: " + r.GetPerimeter());
            Console.WriteLine("Area of Circle: " + c.GetArea());
            Console.WriteLine("Perimeter of Circle: " + c.GetPerimeter());
            Console.WriteLine("Area of Triangle: " + t.GetArea());
            Console.WriteLine("Perimeter of Triangle: " + t.GetPerimeter());

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        
    }
}
