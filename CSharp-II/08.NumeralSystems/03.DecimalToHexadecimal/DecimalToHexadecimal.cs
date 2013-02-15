using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("This program converts decimal numbers to their hexadecimal representation.");
        Console.Write("Please enter decimal number: ");
        int n;
        int.TryParse(Console.ReadLine(), out n);
        Console.Write("The hexadecimal representation of the number is: ");
        Console.WriteLine(Convert.ToString(n, 16));
    }
}

