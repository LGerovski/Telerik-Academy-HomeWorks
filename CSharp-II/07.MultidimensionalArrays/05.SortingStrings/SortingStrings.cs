using System;
using System.Linq;

class SortingStrings
{
    static void Main()
    {
        Console.WriteLine("This program by given array of strings, sorts the array\n" +
            "by the length of its elements (the number of characters composing them).\n");
        string[] input = new string[]
	    {
	        "Bulgaria",
	        "Rumania",
	        "Germany",
	        "USA",
	        "France",
            "Italia"
	    };
        Console.WriteLine("Original Array.\n");
        foreach (string country in input)
        {
            Console.WriteLine(country);
        }
        Console.WriteLine();
        Console.WriteLine("Sorted Array.\n");
        var sortedArray = from item in input
                   orderby item.Length
                   select item;

        foreach (string item in sortedArray)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}

