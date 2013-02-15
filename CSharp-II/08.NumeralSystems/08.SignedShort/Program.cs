using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("This program shows the binary representation of given\n" + 
            "16-bit signed integer number (the C# type short).");
        Console.Write("Please enter a short integer number: ");
        short n;
        short.TryParse(Console.ReadLine(), out n);
        Console.Write("The binary representation of the number is: ");
        Console.WriteLine(Convert.ToString(n, 2));
    }
}

