using System;
using System.Text;

// 30.06.2013
// 19:25:13

class FutureTime
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("This program reads a date and time given in the format: day.month.year\n" +
            "hour:minute:second and prints the date and time after 6 hours and 30 minutes.");
        Console.WriteLine("Along with the day of week in Bulgarian.");
        Console.Write("\nPlease enter the date day.month.year: ");
        string[] input = Console.ReadLine().Split('.');
        Console.Write("\nPlease enter the time hour:minute:second: ");
        string currentDate = String.Format("{0}-{1}-{2} {3}", input[2], input[1], input[0], Console.ReadLine());
        DateTime currentTime;
        if (DateTime.TryParse(currentDate, out currentTime))
        {
            DateTime futureTime = currentTime.AddHours(6).AddMinutes(30);
            string output = String.Format("{0}.{1}.{2} {3}:{4}:{5}",futureTime.Day, 
                futureTime.Month, futureTime.Year, futureTime.Hour, futureTime.Minute, futureTime.Second);
            Console.WriteLine("The time after 6:30 hours would be: {0}", output);
            Console.WriteLine("The day of the week in Bulgarian will be: {0}", Bulgarian(futureTime.DayOfWeek));
        }
        else
        {
            Console.WriteLine("\nWrong input.\n");
        }
    }
    private static string Bulgarian(DayOfWeek dayOfWeek)
    {
        switch (dayOfWeek)
        {
            case DayOfWeek.Friday: return "Петък";
            case DayOfWeek.Monday: return "Понеделник";
            case DayOfWeek.Saturday: return "Събота";
            case DayOfWeek.Sunday: return "Неделя";
            case DayOfWeek.Thursday: return "Четвъртък";
            case DayOfWeek.Tuesday: return "Вторник";
            case DayOfWeek.Wednesday: return "Сряда";
            default: return "";
        }
    }
}

