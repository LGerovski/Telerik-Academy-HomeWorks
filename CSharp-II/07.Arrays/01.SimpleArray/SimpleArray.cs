using System;

class SimpleArray
{
    static void Main()
    {
        Console.WriteLine("This program allocates array of 20 integers and\n" +
                "initializes each element by its index multiplied by 5.\n");
        int[] arrayOfIntegers = new int[20];
        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            arrayOfIntegers[i] = i * 5;
            Console.WriteLine("N[{0}] = {1}", i, arrayOfIntegers[i]);
        }
        Console.WriteLine();
    }
}

