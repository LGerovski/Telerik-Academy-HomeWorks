using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitCheck
{
    private static void PrintError()
    {
        Console.WriteLine("\nWrong Input.\n");
    }
    static void Main()
    {
        Console.WriteLine("This program checks if the bit at position \"p\"," +
        "\nin a given integer number \"v\" has value of 1.\n");
        int intNumber = 0;
        int position = 0;
        Console.Write("Enter a Integer number \"v\": ");
        if (int.TryParse(Console.ReadLine(), out intNumber))
        {
            Console.Write("Enter bit to be checked \"p\" valid interval [0..31]: ");
            if (int.TryParse(Console.ReadLine(), out position) && (position >= 0 && position <= 31))
            {
                int mask = 1 << position;
                bool bitValue = Convert.ToBoolean(intNumber & mask);
                Console.WriteLine("\nv = {0}; p = {1} -> {2}.\n", intNumber, position, bitValue);
            }
            else
            {
                PrintError();
            }
        }
        else
        {
            PrintError();
        }
    }
}

