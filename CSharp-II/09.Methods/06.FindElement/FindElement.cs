using System;

class FindElement
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
    private static int GetSearchedNumber()
    {
        int searchedNumber = 0;
        Console.Write("\nPlease enter the index of the searched element = ");
        if (int.TryParse(Console.ReadLine(), out searchedNumber))
        {
            return searchedNumber; // Returns the index of the searched element.
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
    static bool CheckElement(int[] array, int number)
    {       // Checks if the element is inside the array and not first or last and also if the array size is bigger than 2
        if (number <= 0 || number >= array.Length - 1 || array.Length < 3)
        {
            return false;
        }
        else
        {   // checks if the two neighbour elements are satisfaing the condition
            if (array[number - 1] < array[number] && array[number + 1] < array[number])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    static void PrintResult(int number)
    {
        Console.WriteLine("\nThe count of the searched number is: {0}\n", number);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("This program returns the index of the first element in array\n" + 
            "that is bigger than its neighbors, or -1, if there’s no such element.");
        uint n = GetArraySize();
        int[] arrayN = GetArray(n);
        bool elementExist = false;
        for (int i = 0; i < arrayN.Length; i++)
        {
            elementExist = CheckElement(arrayN, i);
            if (elementExist)
            {
                break;
            }
        }
        if (elementExist)
        {
            Console.WriteLine("There is such element.");
        }
        else
        {
            Console.WriteLine("No such element exist.");
        }
    }
}

