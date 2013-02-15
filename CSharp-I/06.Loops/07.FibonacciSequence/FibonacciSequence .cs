using System;
using System.Numerics;

class FibonacciSequence 
{
    static void Answer(BigInteger number, ulong n)
    {
        Console.WriteLine("\nThe {0} number of the sequence of Fibonacci is: {1}", n, number);
    }
    static void Main()
    {
        Console.Write("This program reads a number N and calculates the sum\n" +
            "of the first N members of the sequence of Fibonacci. Please enter N: ");
        ulong n;
        if (ulong.TryParse(Console.ReadLine(), out n) && n > 0)
        {
            BigInteger firstFibonacci = 0;
            BigInteger secondFibonacci = 1;
            BigInteger sequenceFibonacci = 1;
            if (n == 1)
            {
                Answer(firstFibonacci, n);
            }
            else
            {
                if (n == 2)
                {
                    Answer(secondFibonacci, n);
                }
                else
                {
                    if (n == 3)
                    {
                        Answer(sequenceFibonacci, n);
                    }
                    else
                    {
                        for (ulong i = 4; i <= n; i++)
                        {
                            firstFibonacci = secondFibonacci;
                            secondFibonacci = sequenceFibonacci;
                            sequenceFibonacci = firstFibonacci + secondFibonacci;
                        }
                        Answer(sequenceFibonacci, n);
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

