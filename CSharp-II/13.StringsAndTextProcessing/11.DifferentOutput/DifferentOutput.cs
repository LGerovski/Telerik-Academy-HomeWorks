using System;
using System.Globalization;
using System.Threading;

class DifferentOutput
{
    static void Main()
    {
        Console.WriteLine("This program reads a number and prints it as a decimal number,\n" + 
            "hexadecimal number, percentage and in scientific notation.");
        Console.WriteLine("The output will be aligned right in 15 symbols.");
        Console.Write("\nPlease enter a number to be formatted: ");
        int value;
        if (int.TryParse(Console.ReadLine(), out value))
        {
            string decValue = String.Format("{0:D}", value);
            string hexValue = String.Format("{0:X}", value);
            string perValue = String.Format("{0:P}", value);
            string sciValue = String.Format("{0:E}", value);
            Console.WriteLine("\nDecimal: {0,15}", decValue);
            Console.WriteLine("Hexadecimal: {0,15}", hexValue);
            Console.WriteLine("Percentage: {0,15}", perValue);
            Console.WriteLine("Scientific: {0,15}\n", sciValue);
        }
    }
}

