using System;

class CorrectBrackets
{
    private static bool CheckBrackets(string input)
    {
        int count = 0;
        foreach (var item in input)
        {
            if (item == '(')
            {
                count++;
            }
            else if (item == ')')
            {
                count--;
            }
            if (count < 0)
            {
                return false;
            }
        }
        if (count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        Console.WriteLine("This program checks if in a given expression the brackets are put correctly.");
        Console.Write("\nPlease enter the expression you would like to get checked: ");
        string input = Console.ReadLine();
        bool result = CheckBrackets(input);
        if (result)
        {
            Console.WriteLine("\nThe brackets are entered in correct way.\n");
        }
        else
        {
            Console.WriteLine("\nThe brackets are entered in incorrect way.\n");
        }
    }
}

