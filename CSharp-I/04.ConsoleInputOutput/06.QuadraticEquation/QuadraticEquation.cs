using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("This program reads the coefficients a, b and c of a quadratic equation \n" +
            "ax2+bx+c=0 and solves it (prints its real roots).");
        Console.Write("\nPlease enter coeficient a: ");
        double a, b, c;
        double x1, x2;
        if (double.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Please entercoeficient b: ");
            if (double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Please enter coeficient c: ");
                if (double.TryParse(Console.ReadLine(), out c))
                {
                    if ((b*b - 4*a*c) < 0)
                    {
                        Console.WriteLine("\nThis equation has no real solutions.\n");
                    }
                    else if ((b*b - 4*a*c) == 0)
                    {
                        x1 = (-b / (2*a));
                        Console.WriteLine("\nThis equation has only one solution x1 = x2 = {0}.\n", x1);
                    }
                    else
                    {
                        x1 = (- b - Math.Sqrt(b*b - 4*a*c)) / (2*a);
                        x2 = (- b + Math.Sqrt(b*b - 4*a*c)) / (2*a);
                        Console.WriteLine("\nThe solutions of the equation are x1 = {0} and x2 = {1}.\n", x1, x2);
                    }
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
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
    }
}

