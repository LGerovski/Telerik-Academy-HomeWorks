using System;

class QuickSort
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
    static string[] GetArray(uint arraySize)
    {
        string[] newArray = new string[arraySize];
        Console.WriteLine();
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Please enter element N[{0}]: ", i);
            newArray[i] = Console.ReadLine(); // fills the elements of the array
        }
        return newArray; // returns the filled array
    }
    static int GetPivot(string a, string b, string c, int indexA, int indexB, int indexC)
    {
        if (a.CompareTo(b) > 0)
	    {
		    if (b.CompareTo(c) > 0)
	        {
                return indexB;
	        }
            else
            {
                if (a.CompareTo(c) > 0)
                {
                    return indexC;
                }
                else
                {
                    return indexA;
                }
            }
	    }
        else
        {
            if (b.CompareTo(c) < 0)
            {
                return indexB;
            }
            else
            {
                if (a.CompareTo(c) < 0)
                {
                    return indexC;
                }
                else
                {
                    return indexA;
                }
            }
        }
    }
    static string[] GetSortedArray(string[] a, int left, int right)
    {
        string pivot = a[(left + right) / 2]; // GetPivot(a[left], a[middle], a[right], left, middle, right);
        int i = left;
        int j = right;
        string exchange = null;
        while (i <= j)
        {
            while (a[i].CompareTo(pivot) < 0)
            {
                i++;
            }
            while (a[j].CompareTo(pivot) > 0)
            {
                j--;
            }
            if (i <= j)
            {
                exchange = a[i];
                a[i] = a[j];
                a[j] = exchange;
                i++;
                j--;
            }
        }
        if (left < j)
        {
            GetSortedArray(a, left, j);
        }
        if (i < right)
        {
            GetSortedArray(a, i, right);
        }
        return a;
    }
    static void PrintResult(string[] sortedArray)
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
        Console.WriteLine("This program sorts an array of strings using the quick sort algorithm.");
        uint n = GetArraySize();
        string[] arrayN = GetArray(n);
        string[] sortedArray = GetSortedArray(arrayN, 0, arrayN.Length - 1);
        PrintResult(sortedArray);
    }
}

