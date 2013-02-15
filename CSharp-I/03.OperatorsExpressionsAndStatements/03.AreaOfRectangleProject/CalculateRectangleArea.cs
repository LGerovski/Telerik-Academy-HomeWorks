using System;

class CalculateRectangleArea
{
    private static void PrintArea(double rectangleArea)
    {
        Console.WriteLine("The area of the rectangle is {0}", rectangleArea);
    }
    static void Main()
    {
        Console.WriteLine("This program calculates the area of rectangle,");
        Console.WriteLine("by width and height input by the user.\n");
        double width = 0.0;
        double height = 0.0;
        Console.Write("Enter the width: ");
        if (double.TryParse(Console.ReadLine(), out width) && width >= 0)
        {
            Console.Write("Enter the height: ");
            if (double.TryParse(Console.ReadLine(), out height) && height >= 0)
            {
                Console.WriteLine();
                PrintArea(width * height);
            }
            else
            {
                Console.WriteLine("Wrong Input.");
            }
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
        Console.WriteLine();
    }
}

