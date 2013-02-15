using System;
using System.Numerics;

class FibonacciSequence
{
    static void Main()
    {
        BigInteger fib1 = 1, fib2 = 1;
        Console.Write("0, {0}, {1}, ", fib1, fib2);
        for (int i = 4; i <= 100; i++)
        {
            fib2 = fib1 + fib2;
            fib1 = fib2 - fib1;
            if (i<100)
            {
                Console.Write("{0}, ", fib2);
            }
            else
            {
                Console.WriteLine("{0}.", fib2);
            }
            
        }
    }
}

