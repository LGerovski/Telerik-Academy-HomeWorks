using System;

class IncreasingSort
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
    static int[] GetSortedArray(int[] array)
    {
        int[] length = new int[array.Length];
        int[] predecessor = new int[array.Length];
        length[0] = 1;
        predecessor[0] = -1;
        int maxLength = 0;
        int elementIndex = -1;
        for (int i = 1; i < array.Length; i++)
        {
            maxLength = 0;
            elementIndex = -1;
            for (int j = 0; j < i; j++)
            {
                if (array[j] <= array[i])
                {
                    if (length[j] > maxLength)
                    {
                        maxLength = length[j];
                        elementIndex = j;
                    }
                }
            }
            if (elementIndex != -1)
	        {
                length[i] = maxLength + 1;
	        }
            else
            {
                length[i] = 1;
            }
            predecessor[i] = elementIndex;
        }
        maxLength = 0;
        for (int i = 0; i < length.Length; i++)
        {
            if (length[i] > maxLength)
            {
                maxLength = length[i];
                elementIndex = i;
            }
        }
        int[] sortedArray = new int[maxLength];
        int index = 0;
        while (elementIndex != -1)
        {
            sortedArray[index] = array[elementIndex];
            elementIndex = predecessor[elementIndex];
            index++;
        }
        Array.Reverse(sortedArray);
        return sortedArray;
    }
    static void PrintResult(int[] array)
    {
        Console.WriteLine("\nThe sorted array is:");
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
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("This program reads an array of integers and removes from it a minimal number\n" +
            "of elements in such way that the remaining array is sorted in increasing order.\n" +
            "Then prints the remaining sorted array.");
        uint n = GetArraySize();
        int[] arrayN = GetArray(n);
        int[] sortedArray = GetSortedArray(arrayN);
        PrintResult(sortedArray);
    }
}

