using System;

// Enter the first date: 27.02.2006
// Enter the second date: 3.03.2006
// Distance: 4 days

class DaysBetween
{
    static void Main()
    {
        Console.WriteLine("This program reads two dates in the format: day.month.year\n" + 
            "and calculates the number of days between them.");
        Console.Write("\nPlease enter the first date: ");
        string[] input = Console.ReadLine().Split('.');
        string formattedDate = String.Format("{0}-{1}-{2}", input[2], input[1], input[0]);
        DateTime firstDate;
        if (DateTime.TryParse(formattedDate, out firstDate))
        {
            Console.Write("\nPlease enter the second date: ");
            input = Console.ReadLine().Split('.');
            formattedDate = String.Format("{0}-{1}-{2}", input[2], input[1], input[0]);
            DateTime secondDate;
            if (DateTime.TryParse(formattedDate, out secondDate))
            {
                TimeSpan span = secondDate.Subtract(firstDate);
                Console.WriteLine("\nDistance: {0} days\n", Math.Abs(span.Days));
            }
            else
            {
                Console.WriteLine("\nWrong input.\n");
            }
        }
        else
        {
            Console.WriteLine("\nWrong input.\n");
        }
    }
}

