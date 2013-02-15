using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger first, second, third;
        int n;
        BigInteger result = 0;

        first = int.Parse(Console.ReadLine());
        second = int.Parse(Console.ReadLine());
        third = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n-3; i++)
        {
            result = first + second + third;
            first = second;
            second = third;
            third = result;
        }
        if (n == 1)
        {
            Console.WriteLine(first);
        }
        else if (n == 2)
        {
            Console.WriteLine(second);
        }
        else if (n == 3)
        {
            Console.WriteLine(third);
        }
        else
        {
            Console.WriteLine(result);
        }
        
    }
}

