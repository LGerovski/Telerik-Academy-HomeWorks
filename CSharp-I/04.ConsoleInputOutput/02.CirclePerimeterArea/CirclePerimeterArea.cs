using System;

class CirclePerimeterArea
{
    static void Main()
    {
        Console.WriteLine("This program calculates the perimeter and area of circle \nthrough radius entered by the user.\n");
        Console.Write("Please enter the radius of the circle: ");
        uint radius;
        if (uint.TryParse(Console.ReadLine(), out radius))
        {
            Console.WriteLine("\nCalculated perimeter is: {0}\n", 2*Math.PI*radius);
            Console.WriteLine("Calculated area is: {0}\n", Math.PI*radius*radius);
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
    }
}

