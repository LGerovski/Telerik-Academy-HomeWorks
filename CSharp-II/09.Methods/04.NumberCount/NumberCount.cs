using System;

class NumberCount
{
    static uint GetArraySize()
    {
        uint size = 0;
        Console.Write("\nPlease enter the size (Integer) of the array N = ");
        if (uint.TryParse(Console.ReadLine(), out size))
        {
            return size; // Returns the size of the array entered by the user
        }
        else
        {
            Console.WriteLine("\nWrong input!\n");
            return 0;
        }
    }
    private static int GetSearchedNumber()
    {
        int searchedNumber = 0;
        Console.Write("\nPlease enter the searched number = ");
        if (int.TryParse(Console.ReadLine(), out searchedNumber))
        {
            return searchedNumber; // Returns the searched Number.
        }
        else
        {
            Console.WriteLine("\nWrong input!\n");
            return 0;
        }
    }
    static int[] GetArray(uint arraySize)
    {
        int[] newArray = new int[arraySize];
        Console.WriteLine();
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Please enter element N[{0}]: ", i);
            if (!(int.TryParse(Console.ReadLine(), out newArray[i]))) // fills the elements of the array
            {
                Console.WriteLine("\nWrong input!\n"); // in case wrong element has been entered, prints error message
            }
        }
        return newArray; // returns the filled array
    }
    static int GetNumberCount(int[] array, int number)
    {
        int numberCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                numberCount++;
            }
        }
        return numberCount;
    }
    static void PrintResult(int number)
    {
        Console.WriteLine("\nThe count of the searched number is: {0}\n", number);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("This program counts how many times given number appears in given array.");
        uint n = GetArraySize();
        int[] arrayN = GetArray(n);
        int searchedNumber = GetSearchedNumber();
        int maxCount = GetNumberCount(arrayN, searchedNumber);
        PrintResult(maxCount);
    }

    
}

