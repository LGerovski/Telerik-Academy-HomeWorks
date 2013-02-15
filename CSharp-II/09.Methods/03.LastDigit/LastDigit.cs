using System;

class LastDigit
{
    static string GetLastDigit(int n)
    {
        string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        return numbers[n % 10];
    }
    static void Main()
    {
        Console.WriteLine("This program returns the last digit of given integer as an English word.");
        Console.Write("\nPlease enter a integer number: ");
        int n = 0;
        if (!(int.TryParse(Console.ReadLine(), out n)))
        {
            Console.WriteLine("\nWrong input, the default velue of 0 will be assumed.");
        }
        Console.WriteLine("\nThelast digit of the number you have entered is: {0}\n", GetLastDigit(n));
    }
}

