using System;

class GCD
{
    static void Main()
    {
        Console.Write("This program calculates the greatest common divisor (GCD) of given two numbers.\n");
        Console.Write("\nPlease enter the first number: ");
        int a;
        if (int.TryParse(Console.ReadLine(), out a))
        {
            int b;
            Console.Write("\nPlease enter the second number: ");
            if (int.TryParse(Console.ReadLine(), out b))
            {
                if (a < b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
                int temporalyB;
                while (b != 0)
                {
                    temporalyB = b;
                    b = a % b;
                    a = temporalyB;
                }
                Console.WriteLine(a);
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
        Console.WriteLine();
    }
}

