using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitExchangeAdvance
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

        Console.WriteLine("This program exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1}\n" +
            "of given 32-bit unsigned integer.\n");
        uint intNumber = 0;
        uint newNember = 0;
        uint firstMask = 0;
        uint secondMask = 0;
        uint zeroMask = 0;
        int p = 0;
        int q = 0;
        uint k = 0;
        Console.Write("Enter a Integer number: ");
        if (uint.TryParse(Console.ReadLine(), out intNumber))
        {
            Console.Write("Enter value for \"p\" valid interval [0..31]: ");
            if (int.TryParse(Console.ReadLine(), out p) && (p >= 0 && p <= 31))
            {
                Console.Write("Enter value for \"q\" valid interval [0..31]: ");
                if (int.TryParse(Console.ReadLine(), out q) && (q >= 0 && q <= 31))
                {
                    if (p > q)
                    {
                        p = p + q;
                        q = p - q;
                        p = p - q;
                    }
                    Console.Write("Enter value for \"k\" valid input [k > 0] and [p+k-1 and q+k-1 <= 31]: ");
                    if (uint.TryParse(Console.ReadLine(), out k) && (k > 0 && p+k-1 <= 31 && q+k+1 <= 31))
                    {
                        for (int i = 0; i < k; i++)
                        {
                            firstMask = firstMask + (uint)Math.Pow(2, i);
                        }
                        secondMask = firstMask;
                        zeroMask = firstMask;
                        firstMask = firstMask << p;
                        secondMask = secondMask << q;
                        firstMask = intNumber & firstMask;
                        firstMask = firstMask << q - p;
                        secondMask = intNumber & secondMask;
                        secondMask = secondMask >> q - p;
                        zeroMask = ~(zeroMask << p);
                        newNember = intNumber & zeroMask;
                        zeroMask = ~(zeroMask);
                        zeroMask = zeroMask << q - p;
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

