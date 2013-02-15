using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        Console.Write("This program calculates and prints the Nth Catalan number by given N.\nPlease enter N: ");
        int n;
        if (int.TryParse(Console.ReadLine(), out n))
        {
            BigInteger Factorial2N = 1;
            BigInteger FactorialN = 1;
            for (int i = n + 2; i <= 2 * n; i++)
            {
                Factorial2N *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                FactorialN *= i;
            }
            Console.WriteLine("\nThe Nth Catalan number is: {0}", Factorial2N / FactorialN);
        }
        else
        {
            Console.WriteLine("\nWrong Input.\n");
        }
        Console.WriteLine();
    }
}

