using System;

class PrintASCII
{
    static void Main()
    {
        for (int i = 0; i < 255; i++)
        {
            Console.Write(" {0}", (char)i);
            if (i % 20 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

