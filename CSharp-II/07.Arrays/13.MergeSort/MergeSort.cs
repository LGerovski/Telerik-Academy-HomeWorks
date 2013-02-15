using System;

class MergeSort
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
    static int[] MergeArrays(int arraySize, int[] leftArray, int[] rightArray)
    {
        int leftIndex = 0;
        int rightIndex = 0;
        int[] sortedArray = new int[arraySize]; // sorted array gets initialized with the combined size of both left and right arrays
        for (int k = 0; k < arraySize; k++)
        {   // here if the right index has reached the end of the right array or the left index has not reached the end of the left array and the left array current element is smaller or equal to the current right array element
            if (rightIndex == rightArray.Length || ((leftIndex < leftArray.Length) && (leftArray[leftIndex] <= rightArray[rightIndex])))
            {
                sortedArray[k] = leftArray[leftIndex];  // then the left array current element gets added to the sorted array
                leftIndex++;  // and then the left index increases to point to the next element in the left array
            }
            else if (leftIndex == leftArray.Length || ((rightIndex < rightArray.Length) && (rightArray[rightIndex] <= leftArray[leftIndex])))
            {  // the same applies here but for the right array
                sortedArray[k] = rightArray[rightIndex];
                rightIndex++;
            }
        }
        return sortedArray;  // returnes the sorted array
    }
    static int[] GetSortedArray(int[] arrayN)
    {
        int arraySize = arrayN.Length;  // gets the size of the array "a"
        if (arraySize == 1)
            return arrayN;                   // when the size of the rezult array becomes 1 returns the array
        int middle = arraySize / 2;  // gets the half size of the array
        int[] leftArray = new int[middle]; // initializes the new left array
        for (int i = 0; i < middle; i++) 
        {
            leftArray[i] = arrayN[i];  // fills the left array
        }
        int[] rightArray = new int[arraySize - middle]; // initializes the new right array
        for (int i = 0; i < arraySize - middle; i++)
        {
            rightArray[i] = arrayN[i + middle]; // fills the right array
        }
        leftArray = GetSortedArray(leftArray); // assignes the result left array to the left array and calls the method with the left array
        rightArray = GetSortedArray(rightArray); // assignes the reult right array to the right array
        int[] sortedArray = MergeArrays(arraySize, leftArray, rightArray); // calls the method for merging the left and right arrays
        return sortedArray;
    }
    static void PrintResult(int[] sortedArray)
    {
        Console.WriteLine("\nThe sorted array is:");
        Console.Write("{");
        for (int i = 0; i < sortedArray.Length; i++)
        {
            if (i < sortedArray.Length - 1)
            {
                Console.Write("{0}, ", sortedArray[i]); // prints the result sequence
            }
            else
            {
                Console.Write("{0}", sortedArray[i]); // prints the result sequence
            }
        }
        Console.WriteLine("}\n");
    }
    static void Main()
    {
        Console.WriteLine("This program sorts an array of integers using the merge sort algorithm.");
        uint n = GetArraySize();
        int[] arrayN = GetArray(n);
        int[] sortedArray = GetSortedArray(arrayN);
        PrintResult(sortedArray);
    }
}

