using System;

class ForestMap
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int k = 0; k < n - (i+1); k++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
        for (int i = n-1; i > 0; i--)
        {
            for (int j = 0; j < i-1; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int k = 0; k < n - i; k++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}

