using System;

class BiggerNumber
{
    static void Main()
    {
        Console.WriteLine("This program gets two numbers from the console \nand prints the greater of them. without using if statements.");
        Console.Write("\nPlease enter the first number: ");
        double firstNumber, secondNumber;
        if (double.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.Write("\nPlease enter the second number: ");
            if (double.TryParse(Console.ReadLine(), out secondNumber))
            {
                if (firstNumber == secondNumber)
                {
                    Console.WriteLine("\nThe two numbers are equal.");
                }
                else
                {
                    Console.WriteLine("\nThe greater number is: {0}", Math.Max(firstNumber, secondNumber));
                }
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

