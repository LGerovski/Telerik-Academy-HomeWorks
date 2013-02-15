using System;
using System.Numerics;

class NKFactorial
{
    static void Main()
    {
        Console.Write("This program calculates N!/K! for given N and K (1<N<K).\n");
        Console.Write("\nPlease enter N: ");
        ulong n;
        if (ulong.TryParse(Console.ReadLine(), out n) && n > 1)
        {
            ulong k;
            Console.Write("\nPlease enter K: ");
            if (ulong.TryParse(Console.ReadLine(), out k) && k > n)
            {
                decimal factorial = 1;
                for (ulong i = n + 1; i <= k; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine("\nN!/K! = {0}", 1 / factorial);
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

