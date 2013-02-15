using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("This program converts hexadecimal numbers to their decimal representation.");
        Console.Write("Please enter hexadecimal number: ");
        int n = Convert.ToInt32(Console.ReadLine(), 16);
        Console.WriteLine("The decimal representation of the number is: {0}", n);
    }
}

