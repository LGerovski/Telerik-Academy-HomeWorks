using System;
using System.Text.RegularExpressions;

// Sample text, could be used for input.
// We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

class GetSentence
{
    static bool ContainWord(string text, string word)
    {
        string stringPattern = String.Format(@"\b{0}\b", word);
        Regex pattern = new Regex(stringPattern);
        if (pattern.IsMatch(text))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        Console.WriteLine("This program extracts from a given text all sentences containing given word.");
        Console.Write("\nPlease enter the text: ");
        string[] text = Console.ReadLine().Split('.');
        Console.Write("\nPlease enter the word: ");
        string word = Console.ReadLine();
        Console.WriteLine("\nThe result text is:\n");
        for (int i = 0; i < text.Length; i++)
        {
            text[i] = text[i].TrimStart();
            if (ContainWord(text[i], word))
            {
                Console.WriteLine(text[i] + ".");
            }
        }
        Console.WriteLine();
    }
}

