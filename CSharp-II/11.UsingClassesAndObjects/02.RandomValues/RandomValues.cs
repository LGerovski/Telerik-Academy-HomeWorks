using System;

class RandomValues
{
    static void Main()
    {
        Console.WriteLine("This program generates and prints to the console 10 random values\n" +
                "in the range [100, 200].\n");
        Random randomGenerator = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0,2} random value generated: {1}", i+1, randomGenerator.Next(100, 201));
        }
        Console.WriteLine();
    }
}

