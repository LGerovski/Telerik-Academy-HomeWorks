using System;

class LettersIndex
{
    static void Main()
    {
        Console.WriteLine("This program creates an array containing all letters from the alphabet (A-Z).\n" +
            "Read a word from the console\n" +
            "and prints the index of each of its letters in the array.");
        char[] letters = new char[26];
        for (int i = 0; i < 26; i++)
        {
            letters[i] = (char)(i + 65);
        }
        Console.Write("\nPlease enter a word consisting of capital letters (A-Z): ");
        string input = Console.ReadLine();
        Console.WriteLine();
        foreach (var letter in input)
        {
            if (letter >= 'A' && letter <= 'Z')
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == letter)
                    {
                        Console.WriteLine("The index of letter {0} is: {1}", letter, i);
                    }
                }
            }
            else
            {
                Console.WriteLine("This is not a capital letter (A-Z). {0}", letter);
            }
        }
        Console.WriteLine();
    }
}

