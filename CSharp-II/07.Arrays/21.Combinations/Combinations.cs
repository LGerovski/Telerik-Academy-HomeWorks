using System;

class Combinations
{
    static int[] numbers;
    static uint GetNAndK(string letter)
    {
        uint size = 0;
        Console.Write("\nPlease enter {0} = ", letter);
        if (uint.TryParse(Console.ReadLine(), out size))
        {
            return size;
        }
        else
        {
            Console.WriteLine("\nWrong input!\n");
            return 0;
        }
    }
    static void Permute(uint n, uint k, int index, int start)
    {
        if (index == k)
        {
            PrintCurrentCombination();
        }
        else
        {
            for (int i = start; i < n; i++)
            {
                numbers[index] = i + 1;
                Permute(n, k, index + 1, i + 1);
            }
        }
    }
    static void PrintCurrentCombination()
    {
        Console.Write("{");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i < numbers.Length - 1)
            {
                Console.Write("{0}, ", numbers[i]); // prints the result variation
            }
            else
            {
                Console.Write("{0}", numbers[i]); // prints the result variation
            }
        }
        Console.WriteLine("}");
    }
    static void Main()
    {
        Console.WriteLine("This program reads two numbers N and K and generates\n" +
            "all the combinations of K distinct elements from the set [1..N].");
        uint n = GetNAndK("N");
        uint k = GetNAndK("K");
        numbers = new int[k];
        Permute(n, k, 0, 0);
    }
}

