using System;

class IntDoubleString
{
    private static void PrintInt()
    {
        int number;
        Console.Write("\nPlease enter the int variable: ");
        if (int.TryParse(Console.ReadLine(), out number))
        {
            number++;
            Console.WriteLine("\nAfter the increment the new value of the variable is: {0}\n", number);
        }
        else
        {
            Console.WriteLine("\nWrong Input.\n");
        }
    }
    private static void PrintDouble()
    {
        double number;
        Console.Write("\nPlease enter the double variable: ");
        if (double.TryParse(Console.ReadLine(), out number))
        {
            number++;
            Console.WriteLine("\nAfter the increment the new value of the variable is: {0}\n", number);
        }
        else
        {
            Console.WriteLine("\nWrong Input.\n");
        }
    }
    private static void PrintString()
    {
        string variable;
        Console.Write("\nPlease enter the string variable: ");
        variable = Console.ReadLine();
        variable += "*";
        Console.WriteLine("\nAfter the append the new value of the variable is: {0}\n", variable);
    }
    static void Main()
    {
        Console.WriteLine("This program depending on the user's choice inputs int, \n" +
            "double or string variable. If the variable is integer or double, \n" +
            "increases it with 1. If the variable is string, appends \" * \" at its end. ");
        Console.Write("\n1 - for Int \n2 - for Double \n3 - for String \n\nPlease choose: ");
        byte choice;
        if (byte.TryParse(Console.ReadLine(), out choice) && (choice > 0 && choice < 4))
        {
            switch (choice)
            {
                case 1: PrintInt();
                    break;
                case 2: PrintDouble();
                    break;
                case 3: PrintString();
                    break;
                default: Console.WriteLine("\nWrong Input.\n");
                    break;
            }
        }
        else
        {
            Console.WriteLine("\nWrong Input.\n");
        }
    }
}

