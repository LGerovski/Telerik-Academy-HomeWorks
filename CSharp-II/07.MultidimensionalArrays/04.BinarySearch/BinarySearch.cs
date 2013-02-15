using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("This program reads from the console an array of N integers and an integer K,\n" +
            "sorts the array and using the method Array.BinSearch()\n" +
            "finds the largest number in the array which is ≤ K.");
        int[] array = { 10, 20, 30, 40, 50, 60, 70, 80 };
        int k = 5;
        //int result = Array.BinarySearch(intArray, k);
        //Console.WriteLine(result);
        Console.WriteLine();
        Array.Sort(array);
        int pos = Array.BinarySearch(array, k);
        if (pos < 0)
        {
            pos = ~pos - 1;
        }
        if (pos < 0)
        {
            Console.WriteLine("There is no number in the array which is smaller or equal to K.\n");
        }
        else
        {
            Console.WriteLine(array[pos]);
        }

    }
}

