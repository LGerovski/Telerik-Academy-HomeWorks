using System;

class FillMatrixClass
{
    static int n;
    static int[,] intArray;
    static int number = 0;
    public static void FillMatrix(int Count)
    {
        for (int i = Count; i <= n - Count; i++)
        {
            intArray[Count, i] = GetNumber();
        }
        for (int i = Count + 1; i <= n - Count; i++)
        {
            intArray[i, n - Count] = GetNumber();
        }
        for (int i = Count + 1; i <= n - Count; i++)
        {
            intArray[n - Count, n - i] = GetNumber();
        }
        for (int i = Count + 1; i <= n - (Count + 1); i++)
        {
            intArray[n - i, Count] = GetNumber();
        }
    }
    public static int GetNumber()
    {
        number++;
        return number;
    }
    public static void PrintMatrix()
    {
        for (int i = 0; i < intArray.GetLength(0); i++)
        {
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                Console.Write("{0,3} ", intArray[i, j]);
            }
            Console.WriteLine();
        }
    }
    public static void SetN(int k)
    {
        n = k - 1;
        intArray = new int[k, k];
    }
    static void Main()
    {
        Console.Write("This program reads a positive integer number N (N < 20)" +
                "\nfrom console and outputs in the console the numbers 1 ... N" +
                "\narranged as a spiral. Please enter N: ");
        byte k;
        if (byte.TryParse(Console.ReadLine(), out k) && k < 20)
        {
            Console.WriteLine();
            SetN(k);
            for (int i = 0; i < 10; i++)
            {
                FillMatrix(i);
            }
            PrintMatrix();
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("\nWrong Input.\n");
        }
        
    }
}

