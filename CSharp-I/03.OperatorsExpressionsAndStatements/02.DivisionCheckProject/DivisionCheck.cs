using System;

class DivisionCheck
{
    private static void PrintMessage(bool message)
    {
        Console.WriteLine("The number can be divided" +
            " (without remainder) by 7 and 5? {0}", message);
    }
    static void Main()
    {
        int intNumber = 0;
        Console.Write("Enter a Integer number: ");
        if (int.TryParse(Console.ReadLine(), out intNumber))
        {
            bool canBeDivided = !Convert.ToBoolean(intNumber % 35);
            PrintMessage(canBeDivided);
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
    }
}

