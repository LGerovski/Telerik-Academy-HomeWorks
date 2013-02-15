using System;

class CompareArrays
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
    static object[] GetArray(uint arraySize, string letter)
    {
        object[] newArray = new object[arraySize];
        Console.WriteLine();
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Please enter element {0}[{1}]: ", letter, i);
            newArray[i] = Console.ReadLine();
        }
        return newArray;
    }
    static void CompareArray(object[] array1, object[] array2)
    {
        uint shorterArray = (uint)Math.Min(array1.Length, array2.Length);
        Console.WriteLine();
        for (int i = 0; i < shorterArray; i++)
        {
            Console.WriteLine("N[{0}] = M[{0}] : {1}", i, array1[i].Equals(array2[i]));
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("This program reads two arrays from the console" +
                          "\nand compares them element by element.");
        uint n = GetArraySize("first", "N");
        object[] arrayN = GetArray(n, "N");
        uint m = GetArraySize("second", "M");
        object[] arrayM = GetArray(m, "M");
        CompareArray(arrayN, arrayM);
    }
}

