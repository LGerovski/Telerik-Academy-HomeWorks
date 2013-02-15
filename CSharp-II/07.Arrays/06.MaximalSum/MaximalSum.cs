using System;

class MaximalSum
{
    static int[] resultArray;
    static int[] currentArray;
    static int maxSum = 0;

    static uint GetArraySize(string letter)
    {
        uint size = 0;
        Console.Write("\nPlease enter {0} = ", letter);
        if (uint.TryParse(Console.ReadLine(), out size))
        {
            return size;
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
    static int[] GetMaximalSum(int[] array, uint k, uint n, uint index, uint start)
    {
        if (index == k)
        {
            int currentSum = 0;
            for (int i = 0; i < k; i++)
            {
                currentSum += currentArray[i];
            }
            if (maxSum < currentSum)
            {
                maxSum = currentSum;
                for (int i = 0; i < k; i++)
                {
                    resultArray[i] = currentArray[i];
                }
            }
        }
        else
        {
            for (uint i = start; i < n; i++)
            {
                currentArray[index] = array[i];
                GetMaximalSum(array, k, n, index + 1, i + 1);
            }
        }
        return resultArray;
    }
    static void PrintResult(int[] array, uint k)
    {
        Console.WriteLine("\nThe {0} elements that have maximal sum are:", k);
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
        Console.WriteLine("This program reads two integer numbers N and K (K <= N)\n" +
            "and an array of N elements from the console\n" +
            "and finds in the array those K elements that have maximal sum.");
        Console.WriteLine("In case there are many subsets of K elements with maximal sum\n" +
            "it finds the first one.");
        uint n = GetArraySize("N");
        uint k = GetArraySize("K");
        if (k > n)
        {
            Console.WriteLine("\nK can not be higher than N.\n");
        }
        else
        {
            int[] arrayN = GetArray(n);
            resultArray = new int[k];
            currentArray = new int[k];
            int[] maxSum = GetMaximalSum(arrayN, k, n, 0, 0);
            PrintResult(maxSum, k);
        }
    }
}

