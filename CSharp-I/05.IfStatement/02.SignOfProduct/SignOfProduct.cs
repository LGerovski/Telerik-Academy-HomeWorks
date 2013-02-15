using System;

class SignOfProduct
{
    static void Main()
    {
        Console.WriteLine("This program shows the sign (+ or -) \nof the product of three real numbers without calculating it.");
        double x, y, z;
        bool flag = true;
        Console.Write("\nPlease enter the first number: ");
        if (double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("\nPlease enter the second number: ");
            if (double.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("\nPlease enter the third number: ");
                if (double.TryParse(Console.ReadLine(), out z))
                {
                    if (x < 0)
                    {
                        flag = !flag;
                    }
                    if (y < 0)
                    {
                        flag = !flag;
                    }
                    if (z < 0)
                    {
                        flag = !flag;
                    }
                    if (x == 0 || y == 0 || z == 0)
                    {
                        Console.WriteLine("\nThe product of the three numbers would be: 0\n");
                    }
                    else
                    {
                        if (flag)
                        {
                            Console.WriteLine("\nThe resultant sign of the product would be: +\n");
                        }
                        else
                        {
                            Console.WriteLine("\nThe resultant sign of the product would be: -\n");
                        }
                    }
                    
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

