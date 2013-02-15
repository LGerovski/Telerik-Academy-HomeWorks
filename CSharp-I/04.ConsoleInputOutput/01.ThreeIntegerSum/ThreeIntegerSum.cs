using System;

class ThreeIntegerSum
{
    static void Main()
    {
        Console.WriteLine("This program calculates the sum of three interger numbers entered by the user.");
        Console.Write("Please enter the first number: ");
        int firstNumber, secondNumber, thirdNumber;
        if (int.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.Write("Please enter the second number: ");
            if (int.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.Write("Please enter the third number: ");
                if (int.TryParse(Console.ReadLine(), out thirdNumber))
                {
                    int sum = firstNumber + secondNumber + thirdNumber;
                    Console.WriteLine("The sum of three numbers is: {0}", sum);
                }
                else
                {
                    Console.WriteLine("Wrong Input.");
                }
            }
            else
            {
                Console.WriteLine("Wrong Input.");
            }
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
    }
}

