using System;

namespace _01.Figures
{
    class Circle : Shape
    {
        public Circle(double radius) : base(radius, radius) { }
        public override double CalculateSurface()
        {
            return this.Width * this.Height * Math.PI;
        }
    }
}
