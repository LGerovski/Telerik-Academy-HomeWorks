using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractBit
{
    private static void PrintError()
    {
        Console.WriteLine("\nWrong Input.\n");
    }
    static void Main()
    {
        Console.WriteLine("This program extracts from a given integer \"i\",\n" +
        "the value of a given bit number \"b\".\n");
        int intNumber = 0;
        int position = 0;
        Console.Write("Enter a Integer number \"i\": ");
        if (int.TryParse(Console.ReadLine(), out intNumber))
        {
            Console.Write("Enter bit to be extracted \"b\" valid interval [0..31]: ");
            if (int.TryParse(Console.ReadLine(), out position) && (position >= 0 && position <= 31))
            {
                int mask = 1 << position;
                int bitValue = intNumber & mask;
                bitValue = bitValue >> position;
                Console.WriteLine("\ni = {0}; b = {1} -> value = {2}.\n", intNumber, position, bitValue);
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

