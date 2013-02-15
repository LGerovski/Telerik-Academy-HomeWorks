using System;

class CompareFloat
{

    private static void PrintResult(float floatOne, float floatTwo)
    {
        bool result = floatOne == floatTwo;
        Console.WriteLine("{0} = {1} -> {2}.", floatOne, floatTwo, result);
    }

    static void Main()
    {
        float floatOne = 5.3f;
        float floatTwo = 6.01f;
        PrintResult(floatOne, floatTwo);
        floatOne = 5.00000001f;
        floatTwo = 5.00000003f;
        PrintResult(floatOne, floatTwo);
    }
}

