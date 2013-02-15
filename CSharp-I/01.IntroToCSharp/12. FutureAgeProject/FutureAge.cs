using System;

class FutureAge
{
    static void Main()
    {
        // This solution has in mind that the oldest living person at the moment
        // is 116 years old. :)
        Console.Write("Please enter your current age valid interval is (0-116): ");
        byte currentAge = 0;
        while (true)
        {
            // Because of this condition the loop will continue until the user inputs 
            // a number between 0 and 116.
            if (byte.TryParse(Console.ReadLine(), out currentAge) && currentAge <= 116)
            {
                Console.WriteLine("Your age in ten years time would be: {0}", currentAge + 10);
                break;
            }
            else
            {
                Console.Write("Try again: ");
            }
        }
    }
}

