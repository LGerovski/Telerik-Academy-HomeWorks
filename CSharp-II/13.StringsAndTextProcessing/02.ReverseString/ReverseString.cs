using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("This program reads a string, reverses it and prints the result at the console.");
        Console.Write("Please enter sting to be reversed: ");
        string input = Console.ReadLine();
        char[] reversed = input.ToCharArray();
        Array.Reverse(reversed);
        StringBuilder reversedString = new StringBuilder();
        foreach (var item in reversed)
        {
            reversedString.Append(item);
        }
        Console.WriteLine("The reversed string is: {0}", reversedString);
    }
}

