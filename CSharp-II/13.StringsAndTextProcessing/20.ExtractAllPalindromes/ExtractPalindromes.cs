using System;

// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

class ExtractPalindromes
{
    static void IsPalindrome(string word)
    {
        char[] array = word.ToCharArray();
        Array.Reverse(array);
        string revWord = new string(array);
        if (word == revWord)
        {
            Console.WriteLine(word);
        }
    }
    static void Main()
    {
        Console.WriteLine("This program extracts from a given text all palindromes");
        Console.Write("\nPlease enter some text: ");
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', '"' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("\nThe palindrome words in the text are:");
        foreach (var item in words)
        {
            IsPalindrome(item);
        }
    }
}

