using System;

class MostFrequentNumber
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
    static void GetMostFrequentNumber(int[] array)
    {
        Array.Sort(array);              // sort the array it will help going through it later
        int currentNumber = array[0];
        int maxOccurenceNumber = 0;
        int currentCount = 1;
        int maxCount = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])  // check if the next number is the same as the previous
            {
                currentCount++;  // if yes than increase his counter
            }
            else                    // otherwise
            {
                if (maxCount < currentCount)  // check if the max count is smaller than the current
                {
                    maxCount = currentCount; // if it is smaller then save the current count to max count
                    maxOccurenceNumber = currentNumber; // save the current number as it might be the answer
                }
                currentCount = 1;           // clear current count
                currentNumber = array[i];   // get the new number value
            }
        }
        PrintResult(maxOccurenceNumber, maxCount); // Print the result
    }
    static void PrintResult(int number, int count)
    {
        Console.WriteLine("\nThe most frequent number in the array is -> {0} ({1} times)\n" , number, count);
    }
    static void Main()
    {
        Console.WriteLine("This program finds the most frequent number in an array.");
        Console.WriteLine("In case there are more numbers with the same frequency\n" +
            "it finds the first one.");
        uint n = GetArraySize();
        int[] arrayN = GetArray(n);
        GetMostFrequentNumber(arrayN);
    }
}

