using System;

class SubsetsK
{
    static int[] numbers;
    static bool subsetFound;

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
    static void GetSubsets(int[] arrayN, uint n, uint k, int s, int index, int start)
    {
        if (index == k)
        {
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += numbers[i];
            }
            if (sum == s)
            {
                PrintCurrentSubset(numbers);
            }
        }
        else
        {
            for (int i = start; i < n; i++)
            {
                numbers[index] = arrayN[i];
                GetSubsets(arrayN, n, k, s, index + 1, start + 1);  // finds all combinations with a size of K
            }
        }
    }
    static void PrintCurrentSubset(int[] array)
    {
        subsetFound = true;
        Console.Write("{");
        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1)
            {
                Console.Write("{0}, ", array[i]); // prints the result sequence
            }
            else
            {
                Console.Write("{0}", array[i]); // prints the result sequence
            }
        }
        Console.WriteLine("}");
    }
    static void Main()
    {
        Console.WriteLine("This program reads three integer numbers N, K and S\n" +
            "and an array of N elements from the console.\n" +
            "Then finds in the array a subset of K elements\n" +
            "that have sum S or indicate about its absence.");
        Console.WriteLine("In case there are more subsets K with sum S the program prints all of them.");
        uint n = GetArraySize();
        int s = 0;
        Console.Write("\nPlease enter the searched sum S = ");
        if (!(int.TryParse(Console.ReadLine(), out s)))
        {
            Console.WriteLine("\nWrong input!\n");
        }
        uint k = 0;
        Console.Write("\nPlease enter the size of the subset K = ");
        if (!(uint.TryParse(Console.ReadLine(), out k)))
        {
            Console.WriteLine("\nWrong input!\n");
        }
        int[] arrayN = GetArray(n);
        subsetFound = false;
        Console.WriteLine("\nThe subset with sum of {0} are:", s);
        numbers = new int[k];
        GetSubsets(arrayN, n, k, s, 0, 0);
        if (!subsetFound)
        {
            Console.WriteLine("\nThere are no K subsets found with sum of {0}\n", s);
        }
    }
}

