using System;

class NumberSequence
{
    static void Main()
    {
        for (int i = 2; i < 11; i = i + 2)
        {
            Console.Write("{0}, -{1}, ", i, i + 1);
        }
        Console.WriteLine();
    }
}

