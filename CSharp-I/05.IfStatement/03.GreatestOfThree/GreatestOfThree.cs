using System;

class GreatestOfThree
{
    static void Main()
    {
        Console.WriteLine("This program finds the biggest of three integers using nested if statements.");
        int x, y, z;
        Console.Write("\nPlease enter the first integer: ");
        if (int.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("\nPlease enter the second integer: ");
            if (int.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("\nPlease enter the third integer: ");
                if (int.TryParse(Console.ReadLine(), out z))
                {
                    if (x > y)
                    {
                        if (x > z)
                        {
                            Console.WriteLine("\nThe first integer is the biggest.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nThe third integer is the biggest.\n");
                        }
                    }
                    else
                    {
                        if (y > z)
                        {
                            Console.WriteLine("\nThe second integer is the biggest.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nThe third integer is the biggest.\n");
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

