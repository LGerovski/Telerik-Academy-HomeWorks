using System;
using System.Collections.Generic;

class DictionaryClass
{
    static Dictionary<string, string> dictionary = new Dictionary<string, string>();
    static void AddWord()
    {
        Console.Write("\nPlease enter a word: ");
        string word = Console.ReadLine();
        string value;
        if (dictionary.TryGetValue(word, out value))
        {
            Console.WriteLine("\nThis word already exist in the dictionary.");
        }
        else
        {
            Console.Write("\nPlease enter a explanation for the word: ");
            string explanation = Console.ReadLine();
            dictionary.Add(word, explanation);
        }
    }
    static void GetExplanation()
    {
        Console.Write("\nPlease enter a word you would like to check: ");
        string word = Console.ReadLine();
        string value;
        if (dictionary.TryGetValue(word, out value))
        {
            Console.WriteLine("\n{0} - {1}", word, value);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("\nThis word does not exist in the dictionary.");
        }
    }
    static void GetContent()
    {
        Console.WriteLine("\n{0,15} - {1}", "Word", "Explanation");
        foreach (var item in dictionary)
        {
            Console.WriteLine("{0,15} - {1}", item.Key, item.Value);
        }
        Console.ReadLine();
    }
    static void Main()
    {
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");
        Console.WriteLine("This program translates words by using dictionary.");
        bool isWorking = true;
        do
        {
            Console.WriteLine("\nWhat would you like to do:\n");
            Console.WriteLine("1. Check word.");
            Console.WriteLine("2. Enter new word to the dictionary.");
            Console.WriteLine("3. Check the content of the dictioanry.");
            Console.WriteLine("4. Exit the program.");
            Console.Write("\nPlease enter your choice (1 / 2 / 3 / 4): ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1": GetExplanation();
                    break;
                case "2": AddWord();
                    break;
                case "3": GetContent();
                    break;
                case "4": isWorking = false;
                    break;
                default:
                    break;
            }
        } while (isWorking);
    }
}

