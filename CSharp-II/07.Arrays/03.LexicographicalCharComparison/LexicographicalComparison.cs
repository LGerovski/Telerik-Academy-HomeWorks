using System;

class LexicographicalComparison
{
    static uint GetArraySize(string arrayNumber, string letter)
    {
        uint size = 0;
        Console.Write("\nPlease enter the size (Integer) of the {0} array {1} = ", arrayNumber, letter);
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
    static char[] GetArray(uint arraySize, string letter)
    {
        char[] newArray = new char[arraySize];
        Console.WriteLine();
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Please enter (CHAR) element {0}[{1}]: ", letter, i);
            if (!(char.TryParse(Console.ReadLine(), out newArray[i])))
            {
                Console.WriteLine("\nWrong input!\n");
            }
        }
        return newArray;
    }
    static void CompareArray(char[] array1, char[] array2)
    {
        uint shorterArray = (uint)Math.Min(array1.Length, array2.Length);
        Console.WriteLine();
        for (int i = 0; i < shorterArray; i++)
        {
            Console.WriteLine("N[{0}] = M[{0}] : {1}", i, array1[i] == array2[i]); //array1[i].Equals(array2[i])
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("This program compares two char arrays lexicographically (letter by letter).");
        uint n = GetArraySize("first", "N");
        char[] arrayN = GetArray(n, "N");
        uint m = GetArraySize("second", "M");
        char[] arrayM = GetArray(m, "M");
        CompareArray(arrayN, arrayM);
    }
}

