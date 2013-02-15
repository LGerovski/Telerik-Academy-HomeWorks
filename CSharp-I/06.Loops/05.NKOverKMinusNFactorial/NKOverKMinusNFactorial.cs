using System;
using System.Numerics;

class NKOverKMinusNFactorial
{
    static void Main()
    {
        Console.Write("This program calculates N!*K! / (K-N)! for given N and K (1<N<K).\n");
        Console.Write("\nPlease enter K: ");
        ulong k;
        if (ulong.TryParse(Console.ReadLine(), out k) && k > 2)
        {
            ulong n;
            Console.Write("\nPlease enter N: ");
            if (ulong.TryParse(Console.ReadLine(), out n) && n < k && n > 1)
            {
                BigInteger factorial = 1;
                for (ulong i = k - n + 1; i <= k; i++)
                {
                    factorial *= i;
                }
                for (ulong i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine("\nN!*K! / (K-N)! = {0}", factorial);
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

