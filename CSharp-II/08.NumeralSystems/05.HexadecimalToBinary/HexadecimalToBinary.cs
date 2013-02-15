using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("This program converts hexadecimal numbers to their binary representation.");
        Console.Write("Please enter hexadecimal number: ");
        string input = Console.ReadLine();
        input = input.ToLower();
        string binary = null;
        foreach (var item in input)
        {
            switch (item)
            {
                case '0': binary += "0000";
                    break;
                case '1': binary += "0001";
                    break;
                case '2': binary += "0010";
                    break;
                case '3': binary += "0011";
                    break;
                case '4': binary += "0100";
                    break;
                case '5': binary += "0101";
                    break;
                case '6': binary += "0110";
                    break;
                case '7': binary += "0111";
                    break;
                case '8': binary += "1000";
                    break;
                case '9': binary += "1001";
                    break;
                case 'a': binary += "1010";
                    break;
                case 'b': binary += "1011";
                    break;
                case 'c': binary += "1100";
                    break;
                case 'd': binary += "1101";
                    break;
                case 'e': binary += "1110";
                    break;
                case 'f': binary += "1111";
                    break;
                default:
                    break;
            }
        }
        binary = binary.TrimStart('0');
        Console.WriteLine("The binary representation of the number is: {0}", binary);
    }
}

