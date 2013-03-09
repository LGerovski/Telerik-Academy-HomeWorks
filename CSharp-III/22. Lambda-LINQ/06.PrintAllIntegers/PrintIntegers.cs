using System;
using System.Linq;

class PrintIntegers
{
    static int GetSum(int a, int b)
    {
        return a + b;
    }
    static void Main(string[] args)
    {
        int[] newArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
        Console.WriteLine("The original Array:\n");
        foreach (var item in newArray)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine("\n\nThe LAMBDA sorted array:\n");
        var newList = newArray.Where(x => x % 3 == 0 || x % 7 == 0);
        foreach (var item in newList)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine("\n\nThe LINQ sorted array:\n");
        newList =
            from number in newArray
            where number % 3 == 0 || number % 7 == 0
            select number;
        foreach (var item in newList)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine("\n");
    }
}

