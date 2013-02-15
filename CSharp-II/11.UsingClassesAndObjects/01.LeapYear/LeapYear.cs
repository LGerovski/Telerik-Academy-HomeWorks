using System;

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("This program reads a year from the console and checks whether it is a leap.");
        Console.Write("\nPlease enter a year you would like to check valid interval [1...9999]: ");
        ushort year;
        if (ushort.TryParse(Console.ReadLine(), out year) && year < 10000)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("\nThe year you have entered is a leap year.\n");
            }
            else
            {
                Console.WriteLine("\nThe year you have entered is not a leap year.\n");
            }
        }
        else
        {
            Console.WriteLine("\nWrong input.\n");
        }
    }
}

