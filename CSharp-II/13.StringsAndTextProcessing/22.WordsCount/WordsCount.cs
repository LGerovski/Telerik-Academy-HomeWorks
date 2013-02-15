using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

class WordsCount
{
    static void Main()
    {
        Console.WriteLine("This program reads a string from the console and lists all different words\n" + 
            "in the string along with information how many times each word is found.");
        Console.Write("\nPlease enter a string to be read: ");
        char[] separators = { ' ', ',', '.', '!', '?', '"', ':', ';' };
        string input = Console.ReadLine();
        string pattern = String.Format(@"\b\W+\b");
        string[] words = Regex.Split(input, pattern);
        Console.WriteLine();
        Dictionary<string, int> wordsCount = new Dictionary<string, int>();
        foreach (var item in words)
        {
            int value;
            if (wordsCount.TryGetValue(item, out value))
            {
                wordsCount[item] = value + 1;
            }
            else
            {
                wordsCount.Add(item, 1);
            }
        }
        foreach (var item in wordsCount)
        {
            Console.WriteLine("{0} - {1}", item.Key, item.Value);
        }

    }
}

