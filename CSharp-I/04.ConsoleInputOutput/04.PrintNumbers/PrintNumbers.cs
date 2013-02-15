using System;

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine("This program reads two positive integer numbers \nand prints how many numbers p exist between them such that \nthe reminder of the division by 5 is 0 (inclusive).");
        Console.Write("\nPlease enter the first number: ");
        uint firstNumber, secondNumber;
        if (uint.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.Write("\nPlease enter the second number: ");
            if (uint.TryParse(Console.ReadLine(), out secondNumber))
            {
                if (firstNumber > secondNumber)
                {
                    secondNumber = firstNumber + secondNumber;
                    firstNumber = secondNumber - firstNumber;
                    secondNumber = secondNumber - firstNumber;
                }
                int result = 0;
                for (uint i = firstNumber; i <= secondNumber; i++)
                {
                    if (i % 5 == 0)
                    {
                        result++;
                    }
                }
                Console.WriteLine("\np({0},{1}) = {2}.\n", firstNumber, secondNumber, result);
            }
            else
            {
                Console.WriteLine("\nWrong Input.");
            }
        }
        else
        {
            Console.WriteLine("\nWrong Input.");
        }
    }
}

