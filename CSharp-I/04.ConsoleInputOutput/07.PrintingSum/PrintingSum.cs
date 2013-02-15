using System;

class PrintingSum
{
    static void Main()
    {
        Console.WriteLine("This program gets a number n and after that \ngets n more numbers and calculates and prints their sum.");
        Console.Write("\nPlease enter n: ");
        uint n;
        double sum = 0, input;
        if (uint.TryParse(Console.ReadLine(), out n))
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write("\nPlease enter number {0}: ", i);
                if (double.TryParse(Console.ReadLine(), out input))
                {
                    sum += input;
                }
                else
                {
                    Console.WriteLine("Wrong Input.");
                }
            }
            Console.WriteLine("\nThe sum of the numbers you hve entered is: {0}\n", sum);
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
    }
}

