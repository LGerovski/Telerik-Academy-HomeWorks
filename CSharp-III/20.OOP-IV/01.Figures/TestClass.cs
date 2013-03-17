using System;
using System.Collections.Generic;

namespace _01.Figures
{
    class TestClass
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Triangle(5.7, 4));
            shapes.Add(new Rectangle(8, 6));
            shapes.Add(new Circle(5));
            foreach (var shape in shapes)
            {
                Console.WriteLine("Figure: {0, -15} | Area: {1:F2}",shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
