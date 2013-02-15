using System;
using System.Text.RegularExpressions;

// Sample text, could be used for input.
// Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
// Words: "PHP, CLR, Microsoft"

// ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

class ForbiddenWords
{
    static char[] separators = { ',' };

    private static string GetNewText(string text, string[] words)
    {
        foreach (var item in words)
        {
            string trimedItem = item.Trim();
            string pattern = String.Format(@"\b{0}\b", trimedItem);
            string asterisks = new string('*', trimedItem.Length);
            text = Regex.Replace(text, pattern, asterisks); 
        }
        return text;
    }

    static void Main()
    {
        Console.WriteLine("This program replaces forbidden words given in a text with asterisks.");
        Console.Write("\nPlease enter the text: ");
        string text = Console.ReadLine();
        Console.Write("\nPlease enter the words separated with comma: ");
        string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("\nThe result text is:\n");
        string newText = GetNewText(text, words);
        Console.WriteLine(newText);
        Console.WriteLine();
    }
}

