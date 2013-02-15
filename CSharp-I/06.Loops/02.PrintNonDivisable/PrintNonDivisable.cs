using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintNonDivisable
{
    static void Main()
    {
        Console.Write("This program prints all the numbers from 1 to N,\n" +
            "that are not divisible by 3 and 7 at the same time. Please enter N: ");
        ulong n;
        int count = 0;
        if (ulong.TryParse(Console.ReadLine(), out n))
        {
            for (ulong i = 1; i <= n; i++)
            {
                if (i % 7 != 0 || i % 3 != 0)
                {
                    Console.Write("{0,3}", i);
                    count++;
                    if (i != n && count != 10)
                    {
                        Console.Write(", ");
                    }
                    if (count == 10)
                    {
                        Console.WriteLine();
                        count = 0;
                    }
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

