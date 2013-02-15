using System;

class GreatestOfFive
{
    static void Main()
    {
        Console.WriteLine("This program finds the greatest of given 5 variables.");
        double x1, x2, x3, x4, x5;
        double greatest;
        Console.Write("\nPlease enter the first variable: ");
        if (double.TryParse(Console.ReadLine(), out x1))
        {
            Console.Write("\nPlease enter the second variable: ");
            if (double.TryParse(Console.ReadLine(), out x2))
            {
                Console.Write("\nPlease enter the third variable: ");
                if (double.TryParse(Console.ReadLine(), out x3))
                {
                    Console.Write("\nPlease enter the fourth variable: ");
                    if (double.TryParse(Console.ReadLine(), out x4))
                    {
                        Console.Write("\nPlease enter the fifth variable: ");
                        if (double.TryParse(Console.ReadLine(), out x5))
                        {
                            greatest = x1;
                            if (greatest < x2)
                            {
                                greatest = x2;
                            }
                            if (greatest < x3)
                            {
                                greatest = x3;
                            }
                            if (greatest < x4)
                            {
                                greatest = x4;
                            }
                            if (greatest < x5)
                            {
                                greatest = x5;
                            }
                            Console.WriteLine("\nThe greatest among them all is: {0}\n", greatest);
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

