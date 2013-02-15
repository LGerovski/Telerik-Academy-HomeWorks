using System;

class TrapezoidArea
{
    private static void PrintError()
    {
        Console.WriteLine("\nWrong Input.\n");
    }
    static void Main()
    {
        Console.WriteLine("This program calculates trapezoid's area" +
            "\nby given sides \"a\" and \"b\" and height \"h\".\n");
        double a = 0.0;
        double b = 0.0;
        double h = 0.0;
        Console.Write("Please enter side \"a\": ");
        if (double.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Please enter side \"b\": ");
            if (double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Please enter the height \"h\": ");
                if (double.TryParse(Console.ReadLine(), out h))
                {
                    Console.WriteLine("\nThe calculated area of the trapezoid is: {0}\n", (((a + b) / 2) * h));
                }
                else
                {
                    PrintError();
                }
            }
            else
            {
                PrintError();
            }
        }
        else
        {
            PrintError();
        }
    }
}

