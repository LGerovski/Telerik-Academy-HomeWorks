using System;

class SwapInt
{
    private static void PrintAB(int a, int b)
    {
        Console.WriteLine("a = {0}, b = {1}.", a, b);
    }
    static void Main()
    {
        int a = 5;
        int b = 10;
        PrintAB(a, b);
        Console.WriteLine("Swap a and b.");
        a = a + b;
        b = a - b;
        a = a - b;
        PrintAB(a, b);
    }
}

