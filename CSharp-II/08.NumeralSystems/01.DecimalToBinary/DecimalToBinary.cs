using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("This program converts decimal numbers to their binary representation.");
        Console.Write("Please enter a decimal integer number: ");
        int n;
        int.TryParse(Console.ReadLine(), out n);
        Console.Write("The binary representation of the number is: ");
        Console.WriteLine(Convert.ToString(n, 2));
    }
}

