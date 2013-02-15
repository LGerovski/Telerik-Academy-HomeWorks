using System;

class GreaterVar
{
    static void Main()
    {
        Console.WriteLine("This program examines two integer variables \nand exchanges their values if the first one is greater than the second one.");
        Console.Write("\nPlease enter the first variable: ");
        int firstVar, secondVar;
        if (int.TryParse(Console.ReadLine(), out firstVar))
        {
            Console.Write("\nPlease enter the second variable: ");
            if (int.TryParse(Console.ReadLine(), out secondVar))
            {
                if (firstVar > secondVar)
                {
                    secondVar = firstVar + secondVar;
                    firstVar = secondVar - firstVar;
                    secondVar = secondVar - firstVar;
                    Console.WriteLine("\nThe first variable was indeed greater than the second one and now \n" +
                        "the first variable has value of {0}, and the second has value of {1}\n", firstVar, secondVar);
                }
                else
                {
                    Console.WriteLine("\nThe first variable is lesser or equal to the second \nso no exchange has been done.\n");
                }
            }
            else
            {
                Console.WriteLine("\nWrong Input.\n");
            }
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
    }
}

