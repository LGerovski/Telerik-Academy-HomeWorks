using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class NXSum
{
    static BigInteger GetFactorial(ulong n)
    {
        BigInteger factorial = 1;
        for (ulong i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    static void Main()
    {
        Console.Write("This program, for a given two integer numbers N and X,\n" +
            "calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN.\n");
        Console.Write("\nPlease enter N: ");
        ulong n;
        if (ulong.TryParse(Console.ReadLine(), out n) && n > 0)
        {
            ulong x;
            Console.Write("\nPlease enter X: ");
            if (ulong.TryParse(Console.ReadLine(), out x) && x > 0)
            {
                double s = 1;
                for (ulong i = 1; i <= n; i++)
                {
                    s += (double)GetFactorial(i) / Math.Pow(x, i);
                }
                Console.WriteLine("\nThe sum S = 1 + 1!/X + 2!/X2 + … + N!/XN = {0}", s);
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

