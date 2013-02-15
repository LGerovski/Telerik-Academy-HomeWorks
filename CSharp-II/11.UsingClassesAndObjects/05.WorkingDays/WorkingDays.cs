using System;
using System.Collections.Generic;

class WorkingDays
{
    static List<DateTime> holidays = new List<DateTime>();
    private static void FillDates(int year, int month, int day)
    {
        DateTime holiday = new DateTime(year, month, day);
        holidays.Add(holiday);
    }
    private static void GetHolidays(DateTime futureDay)
    {
        for (int i = 2013; i <= futureDay.Year; i++)
        {
            FillDates(i, 1, 1);
            FillDates(i, 3, 3);
            FillDates(i, 5, 1);
            FillDates(i, 5, 6);
            FillDates(i, 5, 24);
            FillDates(i, 9, 6);
            FillDates(i, 9, 22);
            FillDates(i, 11, 1);
            FillDates(i, 12, 24);
            FillDates(i, 12, 25);
            FillDates(i, 12, 26);
        }
    }
    private static bool IsHoliday(DateTime currentDate)
    {
        if (holidays.Contains(currentDate))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private static int GetWorkingDays(DateTime futureDate)
    {
        int workingDays = 0;
        DateTime currentDate = DateTime.Now;
        while (currentDate < futureDate)
        {
            if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
            {
                if (!IsHoliday(currentDate))
                {
                    workingDays++;
                }
            }
            currentDate = currentDate.AddDays(1);
        }
        return workingDays;
    }
        static void Main()
    {
        Console.WriteLine("This program calculates the number of workdays between today and given date.\n");
        Console.WriteLine("Please enter the day to which you want to calculate the working days.");
        Console.Write("The format should be as follows YYYY-MM-DD: ");
        DateTime futureDate;
        int workingDays = 0;
        if (DateTime.TryParse(Console.ReadLine(), out futureDate))
        {
            GetHolidays(futureDate);
            workingDays = GetWorkingDays(futureDate);
            Console.WriteLine("\nThe working days between today and the date you have just specified are: {0}\n", workingDays);
        }
        else
        {
            Console.WriteLine("\nWrong input.\n");
        }
    }
}

