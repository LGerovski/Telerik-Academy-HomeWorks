using System;

class InternalBinaryFloat
{
    private static unsafe void DumpBytes(int* bits)
    {
        string input = Convert.ToString(bits[0], 2);
        input = input.PadLeft(32, '0');
        string sign = input.Substring(0, 1);
        string exponent = input.Substring(1, 8);
        string mantissa = input.Substring(9, 23);
        Console.WriteLine("sign = {0}", sign);
        Console.WriteLine("exponent = {0}", exponent);
        Console.WriteLine("mantissa = {0}", mantissa);
    }
    static unsafe void Main()
    {
        Console.WriteLine("Write a program that shows the internal binary representation of given\n" +  
            "32-bit signed floating-point number in IEEE 754 format (the C# type float).");
        Console.Write("Please enter a float number: ");
        float f;
        float.TryParse(Console.ReadLine(), out f);
        DumpBytes((int*)&f);
        Console.WriteLine();
    }
}

