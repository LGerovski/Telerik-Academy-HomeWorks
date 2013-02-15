using System;

class SequenceOfNumbers
{
    static void Main()
    {
        Console.WriteLine("This program reads an integer number n from the console \nand prints all the numbers in the interval [1..n], each on a single line.\n");
        Console.Write("Please enter a number n: ");
        uint n;
        if (uint.TryParse(Console.ReadLine(), out n))
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
    }
}

