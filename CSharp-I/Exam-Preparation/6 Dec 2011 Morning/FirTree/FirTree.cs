using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = n - i - 2; j > 0; j--)
            {
                Console.Write(".");
            }
            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }
            
            for (int j = n - i - 2; j > 0; j--)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(".");
        }
        Console.Write("*");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(".");
        }
        Console.WriteLine();
    }
}

