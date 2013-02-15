using System;

class PrintMinAndMax
{
    static int GetNumber()
    {
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("\nWrong Input. The curent number will get value of zero.\n");
            return 0;
        }
    }
    static void Main()
    {
        Console.Write("This program reads from the console a sequence of N integer numbers\n" +
            "and returns the minimal and maximal of them.\n");
        Console.Write("\nPlease enter N: ");
        ulong n;
        if (ulong.TryParse(Console.ReadLine(), out n))
        {
            int[] arrayN = new int[n];
            Console.WriteLine();
            for (ulong i = 0; i < n; i++)
            {
                Console.Write("Please enter N[{0}]: ", i);
                arrayN[i] = GetNumber();
            }
            int min = int.MaxValue;
            int max = int.MinValue;
            for (uint i = 0; i < n; i++)
            {
                if (min > arrayN[i])
                {
                    min = arrayN[i];
                }
                if (max < arrayN[i])
                {
                    max = arrayN[i];
                }
            }
            Console.WriteLine("\nThe minimal number is: {0}", min);
            Console.WriteLine("\nThe maximal number is: {0}", max);
        }
        else
        {
            Console.WriteLine("\nWrong Input.\n");
        }
        Console.WriteLine();
    }
}

