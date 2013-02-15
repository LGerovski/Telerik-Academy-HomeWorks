using System;

class IncreasingSequence
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
    static int[] GetMaximalSequence(int[] array)
    {
        Console.WriteLine();
        int currentSequence = 1;
        int maxSequence = 1;
        int startIndex = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                currentSequence++;
            }
            else
            {
                if (maxSequence < currentSequence)
                {
                    maxSequence = currentSequence;
                    startIndex = i - maxSequence + 1;
                }
                currentSequence = 1;
            }
            if (i == array.Length - 2)
            {
                if (maxSequence < currentSequence)
                {
                    maxSequence = currentSequence;
                    startIndex = i - maxSequence + 2;
                }
            }
        }
        int[] resultArray = new int[maxSequence];
        for (int i = startIndex; i < startIndex + maxSequence; i++)
        {
            resultArray[i - startIndex] = array[i];
        }
        return resultArray;
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
        Console.WriteLine("This program finds the maximal increasing sequence in an array.");
        Console.WriteLine("In case there are more sequences of increasing elements with the same size\n" +
            "it finds the first one.");
        uint n = GetArraySize();
        int[] arrayN = GetArray(n);
        int[] maxSequence = GetMaximalSequence(arrayN);
        PrintResult(maxSequence);
    }
}

