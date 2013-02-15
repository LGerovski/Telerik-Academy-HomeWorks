using System;

class CheckPoint
{
    private static string GetResult(double x, double y)
    {
        if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 25)
        {
            return "within";
        }
        else
        {
            return "not within";
        }
    }
    static void Main()
    {
        Console.WriteLine("This program check if given point with ");
        Console.WriteLine("coordinates \"x\" and \"y\" input by the user ");
        Console.WriteLine("is within a circle K(0, 5).\n");
        double x = 0.0;
        double y = 0.0;
        string result = "";
        Console.Write("Enter coordinate x: ");
        if (double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Enter coordinate y: ");
            if (double.TryParse(Console.ReadLine(), out y))
            {
                result = GetResult(x, y);
                Console.WriteLine("\nThe point (x, y) is {0} the circle.", result);
            }
            else
            {
                Console.WriteLine("\nWrong Input.");
            }
        }
        else
        {
            Console.WriteLine("\nWrong Input.");
        }
        Console.WriteLine();
    }
}

