using System;

// Sample text, could be used for input.
// We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

class SubstringCount
{
    static void Main()
    {
        Console.WriteLine("This program that finds how many times a substring is contained in a given text.");
        Console.Write("Please enter a text: ");
        string input = Console.ReadLine().ToLower();
        Console.Write("Please enter a substring you are looking for: ");
        string substring = Console.ReadLine().ToLower();
        int count = 0;
        int index = -1;
        while (true)
        {
            index = input.IndexOf(substring, index + 1);
            if (index != -1)
            {
                count++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("The result is: {0}", count);
    }
}

