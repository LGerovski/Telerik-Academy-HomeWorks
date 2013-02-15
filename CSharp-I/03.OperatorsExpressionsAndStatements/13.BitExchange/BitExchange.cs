using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitExchange
{
    private static void PrintResult(uint n, uint n1)
    {
        Console.WriteLine("\nn  = {0} ({1}) ->\nn1 = {2} ({3}).\n",
            Convert.ToString(n).PadLeft(10), Convert.ToString(n, 2).PadLeft(32, '0'), 
            Convert.ToString(n1).PadLeft(10), Convert.ToString(n1, 2).PadLeft(32, '0'));
    }
    private static void PrintError()
    {
        Console.WriteLine("\nWrong Input.\n");
    }
    static void Main()
    {

        Console.WriteLine("This program exchanges bits 3, 4 and 5 with bits 24, 25 and 26 \n" +
            "of given 32-bit unsigned integer.\n");
        uint intNumber = 0;
        uint newNember = 0;
        uint firstMask = 7 << 3;
        uint secondMask = 7 << 24;
        uint zeroMask = 7;
        Console.Write("Enter a Integer number: ");
        if (uint.TryParse(Console.ReadLine(), out intNumber))
        {
            firstMask = intNumber & firstMask;
            firstMask = firstMask << 21;
            secondMask = intNumber & secondMask;
            secondMask = secondMask >> 21;
            zeroMask = ~(zeroMask << 3);
            newNember = intNumber & zeroMask;
            zeroMask = ~(zeroMask);
            zeroMask = zeroMask << 21;
            zeroMask = ~(zeroMask);
            newNember = newNember & zeroMask;
            newNember = newNember | firstMask;
            newNember = newNember | secondMask;
            PrintResult(intNumber, newNember);
        }
        else
        {
            PrintError();
        }
    }
}

