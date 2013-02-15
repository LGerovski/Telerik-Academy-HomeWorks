using System;

class AllPermutations
{
    static int[] used;
    static int[] numbers;
    static void Permute(uint n, int k)
    {
        if (k == n)
        {
            Console.Write("{");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < numbers.Length - 1)
                {
                    Console.Write("{0}, ", numbers[i]); // prints the result permutation
                }
                else
                {
                    Console.Write("{0}", numbers[i]); // prints the result permutation
                }
            }
            Console.WriteLine("}");
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                if (used[i] == 0)
                {
                    used[i] = 1;
                    numbers[k] = i + 1;
                    Permute(n, k + 1);
                    used[i] = 0;
                }
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("This program reads a number N and generates and prints\n" +
            "all the permutations of the numbers [1 … N].");
        uint n;
        Console.Write("\nPlease enter N = ");
        if (!(uint.TryParse(Console.ReadLine(), out n)))
        {
            Console.WriteLine("\nWrong input!\n");
        }
        used = new int[n];
        numbers = new int[n];
        Permute(n, 0);
    }
}

