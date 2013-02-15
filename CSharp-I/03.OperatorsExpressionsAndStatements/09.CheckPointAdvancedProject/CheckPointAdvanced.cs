using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckPointAdvanced
{
    private static string GetResultCircle(double x, double y)
    {
        if (Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= 9)
        {
            return "within";
        }
        else
        {
            return "outside";
        }
    }
    private static string GetResultRectangle(double x, double y)
    {
        if ((x < -1) || (x > 5) || (y < -1) || (y > 1))
        {
            return "outside";
        }
        else
        {
            return "within";
        }
    }
    private static void PrintError()
    {
        Console.WriteLine("\nWrong Input.\n");
    }
    static void Main()
    {
        Console.WriteLine("This program checks if given point (x, y) is" +
            "\nwithin the circle and out of the rectangle.\n");
        double x = 0.0;
        double y = 0.0;
        Console.Write("Please enter \'X\' coordiante: ");
        if (double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Please enter \'Y\' coordinate: ");
            if (double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("\nThe point is {0} the circle and {1} the recatangle.\n", GetResultCircle(x, y), GetResultRectangle(x, y));
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

