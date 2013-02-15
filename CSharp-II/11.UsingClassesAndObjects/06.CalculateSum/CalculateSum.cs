using System;

class CalculateSum
{
    private static int GetSum(string input)
    {
        int result = 0;
        string[] numbers = input.Split();
        for (int i = 0; i < numbers.Length; i++)
        {
            result += int.Parse(numbers[i]);
        }
        return result;
    }
    static void Main()
    {
        Console.WriteLine("This program reads values from given string and calculates their sum.");
        string input = "43 68 9 23 318";
        Console.WriteLine("\nstring = \"{0}\" -> result = {1}\n", input,  GetSum(input));
    }
}

