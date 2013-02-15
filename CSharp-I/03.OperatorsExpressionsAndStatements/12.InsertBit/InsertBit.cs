using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InsertBit
{
    private static void PrintResult(int n, int p, int v, int result)
    {
        Console.WriteLine("\nn = {0} ({1}), p = {2}, v = {3} -> {4} ({5})\n", n, 
            Convert.ToString(n, 2), p, v, result, Convert.ToString(result, 2));
    }
    private static void PrintError()
    {
        Console.WriteLine("\nWrong Input.\n");
    }
    static void Main()
    {
        Console.WriteLine("This program inserts bit \"v\" into a given integer \"n\" " +
        "at position \"p\".\n");
        int intNumber = 0;
        int position = 0;
        int bitValue = 0;
        int result = 0;
        Console.Write("Enter a Integer number \"n\": ");
        if (int.TryParse(Console.ReadLine(), out intNumber))
        {
            Console.Write("Enter position for the bit to be inserted \"p\" valid interval [0..31]: ");
            if (int.TryParse(Console.ReadLine(), out position) && (position >= 0 && position <= 31))
            {
                Console.Write("Enter bit value \"v\" valid interval [0..1]: ");
                if (int.TryParse(Console.ReadLine(), out bitValue) && (bitValue >= 0 && bitValue <= 1))
                {
                    if (bitValue == 1)
	                {
		                int mask = 1 << position;
                        result = intNumber | mask;
	                }
                    if (bitValue == 0)
                    {
                        int mask = ~(1 << position);
                        result = intNumber & mask;
                    }
                    PrintResult(intNumber, position, bitValue, result);
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
        else
        {
            PrintError();
        }
    }
}

