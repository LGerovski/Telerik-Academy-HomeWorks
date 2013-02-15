using System;

class PrintNNumbers
{
    static void Main()
    {
        Console.Write("This program prints all the numbers from 1 to N. Please enter N: ");
        ulong n;
        if (ulong.TryParse(Console.ReadLine(), out n))
        {
            for (ulong i = 1; i <= n; i++)
            {
                Console.Write("{0,3}", i);
                if (i != n && i % 10 != 0)
                {
                    Console.Write(", ");
                }
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        else
        {
            Console.WriteLine("\nWrong Input.\n");
        }
        Console.WriteLine();
    }
}

