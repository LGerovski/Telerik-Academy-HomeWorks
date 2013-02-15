using System;

class SieveOfEratosthenes 
{
    static void Main()
    {
        Console.WriteLine("This program finds all prime numbers in the range [1...10 000 000].");
        int[] eratosthen = new int[10000000];
        for (int i = 0; i < eratosthen.Length; i++)
        {
            eratosthen[i] = i + 1;
        }
        int p = 2;
        while (Math.Pow(p, 2) < 10000000)
        {
            for (int i = 2 * p; i <= 10000000; i += p)
            {
                eratosthen[i - 1] = -1;
            }
            while (eratosthen[p] == -1)
            {
                p++;
            }
            p = eratosthen[p];
        }
        for (int i = 0; i < 10000000; i++)
        {
            if (eratosthen[i] != -1)
            {
                Console.Write("{0} ", eratosthen[i]);
            }
        }
    }
}