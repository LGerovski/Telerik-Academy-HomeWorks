using System;

class CheckThirdBit
{
    private static void PrintBit(int bit)
    {
        Console.WriteLine("The third bit of the number you have entered is {0}.", bit);
    }
    static void Main()
    {
        int intNumber = 0;
        int mask = 1 << 2;
        Console.Write("Enter a Integer number: ");
        if (int.TryParse(Console.ReadLine(), out intNumber))
        {
            bool thirdBitValue = Convert.ToBoolean(intNumber & mask);
            PrintBit(Convert.ToInt32(thirdBitValue));
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
    }
}

