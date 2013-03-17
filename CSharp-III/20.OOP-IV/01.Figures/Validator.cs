using System;

namespace _01.Figures
{
    class Validator
    {
        public static void ValidateSize(double size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Width and Height cannot be zero or negative.");
            }
        }
        public static void ValidateWH(double width, double height)
        {
            if ((2 * width) <= height || (2 * height) <= width)
            {
                throw new ArgumentException("One size cannot be as twice as small or less than the other side.");
            }
        }
    }
}
