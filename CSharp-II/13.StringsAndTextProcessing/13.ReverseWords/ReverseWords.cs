using System;

// C# is not C++, not PHP and not Delphi!

class ReverseWords
{
    static char[] separators = { ',', ' ', '.', '!', '?' };
    static void Main()
    {
        Console.WriteLine("This program reverses the words in given sentence.");
        Console.Write("\nPlease enter a sentence: ");
        string input = Console.ReadLine();
        string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        string[] reversedWords = (string[])words.Clone();
        Array.Reverse(reversedWords);
        string result = input;
        for (int i = 0; i < words.Length; i++)
        {
            result = result.Replace(words[i], reversedWords[i]);
        }
        Console.WriteLine(result);
    }
}  // to be finished

