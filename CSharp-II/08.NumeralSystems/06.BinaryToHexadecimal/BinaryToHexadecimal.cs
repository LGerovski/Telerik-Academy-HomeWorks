using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("This program converts binary numbers to their hexadecimal representation.");
        Console.Write("Please enter binary number: ");
        string input = Console.ReadLine();
        input = input.PadLeft(((input.Length / 4) + 1) * 4, '0');

        string hexadecimal = null;
        for (int i = 0; i < input.Length; i += 4)
        {
            switch (input.Substring(i, 4))
            {
                case "0000": hexadecimal += "0";
                    break;
                case "0001": hexadecimal += "1";
                    break;
                case "0010": hexadecimal += "2";
                    break;
                case "0011": hexadecimal += "3";
                    break;
                case "0100": hexadecimal += "4";
                    break;
                case "0101": hexadecimal += "5";
                    break;
                case "0110": hexadecimal += "6";
                    break;
                case "0111": hexadecimal += "7";
                    break;
                case "1000": hexadecimal += "8";
                    break;
                case "1001": hexadecimal += "9";
                    break;
                case "1010": hexadecimal += "A";
                    break;
                case "1011": hexadecimal += "B";
                    break;
                case "1100": hexadecimal += "C";
                    break;
                case "1101": hexadecimal += "D";
                    break;
                case "1110": hexadecimal += "E";
                    break;
                case "1111": hexadecimal += "F";
                    break;
                default:
                    break;
            }
        }
        hexadecimal = hexadecimal.TrimStart('0');
        Console.WriteLine("The hexadecimal representation of the number is: {0}", hexadecimal);
    }
}

