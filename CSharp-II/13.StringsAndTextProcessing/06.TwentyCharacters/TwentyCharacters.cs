using System;

class TwentyCharacters
{
    static void Main()
    {
        Console.WriteLine("This program reads from the console a string of maximum 20 characters.\n" + 
            "If the length of the string is less than 20,\n" + 
            "the rest of the characters will be filled with '*'.");
        Console.Write("\nPlease enter a string: ");
        string input = Console.ReadLine();
        input = input.PadRight(20, '*');
        input = input.Substring(0, 20);
        Console.WriteLine("\nResult string: {0}\n", input);
    }
}

