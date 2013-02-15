using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckThirdDigit
{
    private static void PrintMessage(string message)
    {
        Console.WriteLine("The third digit (right-to-left) is 7? {0}.", message);
    }
    static void Main()
    {
        int intNumber = 0;
        Console.Write("Enter a Integer number: ");
        if (int.TryParse(Console.ReadLine(), out intNumber))
        {
            intNumber /= 100;
            if (Math.Abs(intNumber) % 10 == 7)
            {
                PrintMessage("True");
            }
            else
            {
                PrintMessage("False");
            }
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
    }
}

