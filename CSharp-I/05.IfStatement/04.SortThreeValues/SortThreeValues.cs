using System;

class SortThreeValues
{
    static void Main()
    {
        Console.WriteLine("This program sorts 3 real values in descending order using nested if statements.");
        double x, y, z;
        Console.Write("\nPlease enter the first number x: ");
        if (double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("\nPlease enter the second number y: ");
            if (double.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("\nPlease enter the third number z: ");
                if (double.TryParse(Console.ReadLine(), out z))
                {
                    if (y < z)
                    {
                        y = z + y;
                        z = y - z;
                        y = y - z;
                    }
                    if (x < y)
                    {
                        x = y + x;
                        y = x - y;
                        x = x - y;
                    }
                    if (y < z)
                    {
                        y = z + y;
                        z = y - z;
                        y = y - z;
                    }
                    Console.WriteLine("\nAfter ordering the values are as follows -> x = {0}, y = {1}, z = {2}\n", x, y, z);
                }
                else
                {
                    Console.WriteLine("\nWrong Input.\n");
                }
            }
            else
            {
                Console.WriteLine("\nWrong Input.\n");
            }
        }
        else
        {
            Console.WriteLine("\nWrong Input.");
        }
    }
}

