using System;
using System.Text;

// aaaaabbbbbcdddeeeedssaa

class ReplaceLines
{
    static void Main()
    {
        Console.WriteLine("This program reads a string from the console and replaces all series\n" + 
            "of consecutive identical letters with a single one.");
        Console.Write("\nPlease enter a string to be read: ");
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        if (input.Length > 0)
	    {
		    result.Append(input[0]);
	    }
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                result.Append(input[i]);
            }
        }
        Console.WriteLine("\nThe result string is: {0}\n", result);
    }
}

