using System;

class ReverseNumber
{
    static int GetNumber()
    {
        int size = 0;
        Console.Write("\nPlease enter a decimal number N = ");
        if (int.TryParse(Console.ReadLine(), out size))
        {
            return size; // Returns the input decimal number
        }
        else
        {
            Console.WriteLine("\nWrong input!\n");
            return 0;
        }
    }
    static string GetReversedNumber(decimal number)
    {
        string getInput = number.ToString();  // converting the input to string
        char[] array = getInput.ToCharArray(); // converting the string to char array
        Array.Reverse(array);                 // reversing the array elements
        getInput = new string(array);           // converting the array back to string
        return getInput;                        // returning the string, there is no need to convert it back to decimal
    }
    static void Main()
    {
        Console.WriteLine("This program reverses the digits of given decimal number.");
        int input = GetNumber();
        Console.WriteLine("\nThe reversed number is: {0}\n", GetReversedNumber(input));
    }
}

