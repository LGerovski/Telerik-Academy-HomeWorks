using System;

class PrintMatrix
{
    static void Main()
    {
        Console.Write("This program reads from the console a positive integer number N (N < 20)" +
                "\nand outputs a matrix. Please enter N: ");
        byte n;
        if (byte.TryParse(Console.ReadLine(), out n) && n < 20)
        {
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= i + n - 1; j++)
                {
                    Console.Write("{0,3} ", j);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("\nWrong Input.\n");
        }
    }
}

