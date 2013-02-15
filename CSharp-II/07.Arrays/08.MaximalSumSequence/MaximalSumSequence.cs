using System;

class MaximalSumSequence
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
    static int[, ] GetArray(uint arraySize)
    {
        int[, ] newArray = new int[arraySize, 3];
        Console.WriteLine();
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Please enter element N[{0}]: ", i);
            if (!(int.TryParse(Console.ReadLine(), out newArray[i, 0]))) // fills the values of the array
            {
                Console.WriteLine("\nWrong input!\n"); // in case wrong element has been entered, prints error message
            }
        }
        return newArray; // returns the filled array
    }
    static int[, ] FillArray(int[, ] array)
    {
        array[0, 1] = array[0, 0];
        array[0, 2] = 1;
        int n = array.GetLength(0);
        for (int i = 1; i < n; i++)
        {
            if (array[i - 1, 1] + array[i, 0] > array[i, 0]) // checks if the sum of the previous sequence
            {                                               // is higher than the current number
                array[i, 1] = array[i - 1, 1] + array[i, 0]; // if yes save the sum
                array[i, 2] = array[i - 1, 2] + 1;           // and save the length of the sequence
            }
            else                                             // otherwise
            {
                array[i, 1] = array[i, 0];                   // keep only the current number
                array[i, 2] = 1;                             // the length of the sequence at this point is 1
            }
        }
        return array;
    }
    static int[] GetMaxSequence(int[,] array)
    {
        int maxSequenceLength = 1;
        int finalElement = 1;
        int maxSum = array[0, 1];
        int n = array.GetLength(0);
        for (int i = 1; i < n; i++)
        {
            if (array[i, 1] > maxSum)           // checks for the sell where the sum of elements is maximal
            {
                maxSum = array[i, 1];           // gets that sum
                maxSequenceLength = array[i, 2]; // gets the length of the sequence
                finalElement = i;                   // gets the index of the final element in the sequence
            }
        }
        int[] maxSequenceArray = new int[maxSequenceLength];
        for ( int index = 0, i = finalElement - (maxSequenceLength -1); i <= finalElement; i++, index++)
        {
            maxSequenceArray[index] = array[i, 0]; // here transfers the sequence to new array which
        }                                           // the method will return later
        return maxSequenceArray;                    // returnes the array with the required sequence
    }
    static void PrintResult(int[] array)
    {
        Console.WriteLine("\nThe shortest sequence of maximal sum is:");
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
        Console.WriteLine("This program finds the shortest sequence of maximal sum in given array.");
        uint n = GetArraySize();
        int[, ] arrayN = GetArray(n);
        arrayN  = FillArray(arrayN);
        int[] maxSequence = GetMaxSequence(arrayN);
        PrintResult(maxSequence);
    }
}

