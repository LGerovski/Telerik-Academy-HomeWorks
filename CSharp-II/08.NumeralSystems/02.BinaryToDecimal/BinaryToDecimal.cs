using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("This program converts binary numbers to their decimal representation.");
        Console.Write("Please enter bynary number: ");
        int n = Convert.ToInt32(Console.ReadLine(), 2);
        Console.WriteLine("The decimal representation of the number is: {0}", n);
    }
}

