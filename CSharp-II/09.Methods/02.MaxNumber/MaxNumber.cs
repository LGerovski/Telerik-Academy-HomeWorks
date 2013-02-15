using System;

class MaxNumber
{
    static int GetInput(string word)
    {
        Console.Write("\nPlease enter the {0} interger number: ", word);
        int inputNumber = 0;
        if (int.TryParse(Console.ReadLine(), out inputNumber))
        {
            return inputNumber;            
        }
        else
        {
            Console.WriteLine("\nWrong input, the value of 0 will be assumed.\n");
            return 0;
        }
    }
    static int GetMax(int a, int b)
    {
        if (a > b)
	    {
            return a;
	    }
        else
	    {
            return b;
	    }
    }
    static void Main()
    {
        Console.WriteLine("This program reads 3 integers from the console and prints the biggest of them.");
        int a = GetInput("first");
        int b = GetInput("second");
        int c = GetInput("third");
        int greatestNumber = GetMax(a, GetMax(b, c));
        Console.WriteLine("\nThe greatest among the three numbers is: {0}\n", greatestNumber);
    }
}

