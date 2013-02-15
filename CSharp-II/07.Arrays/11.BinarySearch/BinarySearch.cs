using System;

class BinarySearch
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
    static int FindElement(int[] array, int searchedElement, int left, int right)
    {
        if (left == right)
        {
            return -1;
        }
        if (array[(left + right) / 2] > searchedElement)
        {
            return FindElement(array, searchedElement, left, ((left + right) / 2));
        }
        else if (array[(left + right) / 2] < searchedElement)
	    {
		    return FindElement(array, searchedElement, ((left + right) / 2) + 1, right);
	    }
        else
        {
            return (left + right) / 2;
        }
    }
    static void PrintResult(int[] array)
    {
        Console.WriteLine("The maximal sequence of incresing elements is:");
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
        Console.WriteLine("This program finds the index of given element\n" +
            "in a sorted array of integers by using the binary search algorithm.");
        uint n = GetArraySize();
        Console.Write("\nPlease enter the value (Integer) of the element you are searching: ");
        int searchedElement = 0;
        if (!(int.TryParse(Console.ReadLine(), out searchedElement)))
        {
            Console.WriteLine("\nIncorrect input the sum will be set to zero.\n");
        }
        int[] arrayN = GetArray(n);
        Array.Sort(arrayN);
        int elementIndex = FindElement(arrayN, searchedElement, 0, arrayN.Length);
        Console.WriteLine(elementIndex);
    }
}

