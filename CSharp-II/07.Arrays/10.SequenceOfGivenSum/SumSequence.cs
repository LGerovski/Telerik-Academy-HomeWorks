using System;

class SumSequence
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
    static int[] GetSumSequence(int[] array, int sum)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int currentSum = 0;
            for (int j = i; j < array.Length; j++)
            {
                currentSum += array[j];
                if (currentSum == sum)
                {
                    int[] resultArray = new int[(j - i) + 1];
                    for (int k = i; k <= j; k++)
                    {
                        resultArray[k - i] = array[k];
                    }
                    return resultArray;
                }
                if (currentSum > sum)
                {
                    break;
                }
            }
        }
        int[] emptyArray = new int[0];
        return emptyArray;
    }
    static void PrintResult(int[] array, int sum)
    {
        if (array.Length > 0)
        {
            Console.WriteLine("\nThe sequence of elements with the sum of {0} is:", sum);
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
        else
        {
            Console.WriteLine("\nThere is no sequence of elements with the sum of {0} in this array.", sum);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("This program finds in given array of integers\n" +
            "a sequence of given sum S (if present).");
        Console.WriteLine("In case there are more such sequences it finds the first one.");
        uint n = GetArraySize();
        Console.Write("\nPlease enter \"S\" the sum required: ");
        int sum = 0;
        if (!(int.TryParse(Console.ReadLine(), out sum)))
	    {
            Console.WriteLine("\nIncorrect input the sum will be set to zero.\n"); 
	    } 
        int[] arrayN = GetArray(n);
        int[] sumSequence = GetSumSequence(arrayN, sum);
        PrintResult(sumSequence, sum);
    }
}

