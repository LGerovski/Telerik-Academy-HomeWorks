using System;

class DigitName
{
    private static string GetDigit(byte digit)
    {
        switch (digit)
        {
            case 0: return "Zero";
            case 1: return "One";
            case 2: return "Two";
            case 3: return "Three";
            case 4: return "Four";
            case 5: return "Five";
            case 6: return "Six";
            case 7: return "Seven";
            case 8: return "Eight";
            case 9: return "Nine";
            default: return "Wrong Input.";
        }
    }


    static void Main()
    {
        Console.WriteLine("This program asks for a digit and depending on the input " +
            "\nshows the name of that digit.");
        Console.Write("\nPlease enter the digit: ");
        byte digit;
        if (byte.TryParse(Console.ReadLine(), out digit) && digit < 10)
        {
            Console.WriteLine("\nThe digit you have entered was: {0}\n", GetDigit(digit));
        }
        else
        {
            Console.WriteLine("\nWrong Input.\n");
        }
    }
}

