using System;

class SelectionSort
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
        for (int i = 0; i < arraySize; i++)  // one by one asks the user to enter values for all elements
        {
            Console.Write("Please enter element N[{0}]: ", i);
            if (!(int.TryParse(Console.ReadLine(), out newArray[i]))) // fills the elements of the array
            {
                Console.WriteLine("\nWrong input!\n"); // in case wrong element has been entered, prints error message
            }
        }
        return newArray; // returns the filled array
    }
    static int[] SortArray(int[] array, uint n)
    {
        uint minIndex = 0;
        for (uint i = 0; i < n; i++)
        {
            minIndex = i;
            for (uint j = i; j < n; j++)
            {
                if (array[j] < array[minIndex]) // if the element "j" i smaller than the current smaller?
                {                               
                    minIndex = j;               // get the index of the new smaller element
                }
            }
            if (minIndex != i) // if the smallest found element is not the starting?
            {
                array[i] = array[i] + array[minIndex];  
                array[minIndex] = array[i] - array[minIndex];
                array[i] = array[i] - array[minIndex]; 
            }                                           // change the values of the two elements
        }
        return array;  // return the sorted array
    }
    static void PrintResult(int[] array)
    {
        Console.WriteLine("\nThe sorted array is:\n");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("N[{0}] = {1}", i, array[i]); // print the sorted array
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("This program sorts an array using the \"selection sort\" algorithm.");
        uint n = GetArraySize();
        int[] arrayN = GetArray(n);
        int[] sortedArray = SortArray(arrayN, n);
        PrintResult(sortedArray);
    }
}

