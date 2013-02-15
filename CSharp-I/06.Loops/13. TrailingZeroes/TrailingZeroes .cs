using System;

class TrailingZeroes 
{
    static void Main()
    {
        Console.Write("This program calculates for given N" +
            "\nhow many trailing zeros present at the end of the number N!." +
            "\nPlease enter N: ");
        int n;
        if (int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine();
            int zeroesCounter = 0;
            int divisor = 5;
            while (divisor <= n)
            {
                zeroesCounter += n / divisor;
                divisor *= 5;
            }
            Console.WriteLine("The number of trailing zeroes in {0}! is: {1}", n, zeroesCounter);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("\nWrong Input.\n");
        }
    }
}

