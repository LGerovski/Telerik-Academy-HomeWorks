using System;
using System.Collections.Generic;
using System.Linq;

// Write a program that reads a list of words separated by spaces and prints the list in an alphabetical order

class PrintWords
{
    static void Main()
    {
        Console.WriteLine("This program reads a list of words, separated by spaces\n" + 
            "and prints the list in an alphabetical order.");
        Console.Write("\nPlease enter the list of words: ");
        List<string> words = Console.ReadLine().Split().ToList();
        words = words.OrderBy(x => x).ToList();
        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
    }
}

