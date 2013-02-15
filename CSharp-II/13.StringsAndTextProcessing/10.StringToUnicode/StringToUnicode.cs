using System;
using System.Text;

class StringToUnicode
{
    static void Main()
    {
        Console.WriteLine("This program converts a string to a sequence of C# Unicode character literals.");
        Console.Write("\nPlease enter a string to be converted: ");
        string input = Console.ReadLine();
        StringBuilder unicodeText = new StringBuilder();
        foreach (var item in input)
        {
            string currentChar = "\\u" + ((int)item).ToString("X").PadLeft(4, '0');
            unicodeText.Append(currentChar);
        }
        Console.WriteLine("\nResult output: {0}\n", unicodeText);
    }
}

