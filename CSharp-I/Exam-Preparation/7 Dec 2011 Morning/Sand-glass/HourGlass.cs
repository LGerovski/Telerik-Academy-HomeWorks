using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HourGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int i, j, k;
        for (i = 0; i < n / 2 + 1; i++)
        {
            for (j = 0; j < i; j++)
            {
                Console.Write(".");
            }
            for (k = 0; k < n - 2*i; k++)
            {
                Console.Write("*");
            }
            for (j = 0; j < i; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
        for ( i = n / 2 - 1; i >= 0; i--)
        {
            for (j = i; j > 0; j--)
            {
                Console.Write(".");
            }
            for (k = 0; k < n - 2*i; k++)
            {
                Console.Write("*");
            }
            for (j = i; j > 0; j--)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}

