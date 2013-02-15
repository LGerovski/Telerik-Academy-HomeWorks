using System;

class OddOrEven
{
    private static void PrintMessage(string message)
    {
        Console.WriteLine("The number you have entered is {0}.", message);
    }
    static void Main()
    {
        int intNumber = 0;
        Console.Write("Enter a Integer number: ");
        if (int.TryParse(Console.ReadLine(), out intNumber))
        {
            if (intNumber % 2 == 0)
            {
                PrintMessage("even");
            }
            else
            {
                PrintMessage("odd");
            }
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
    }
}

