using System;

namespace _03.CustomException
{
    class TestClass
    {
        private static int GetNumber()
        {
            Console.Write("Please enter a integer number between [1..100]: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 1 || number > 100)
            {
                throw new InvalidRangeException<int>(1, 100, String.Format("The number you have entered is out of the range"));
            }
            return number;
        }
        private static DateTime GetDate()
        {
            Console.Write("Please enter a date in format \"MM.DD.YYYY\" between [1.1.1980 … 31.12.2013]: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            DateTime startDate = DateTime.Parse("01.01.1980");
            DateTime endDate = DateTime.Parse("12.31.2013");
            if (date.CompareTo(startDate) < 0 || date.CompareTo(endDate) > 0)
            {
                throw new InvalidRangeException<DateTime>(startDate, endDate, String.Format("The date you have entered is out of the range"));
            }
            return date;
        }
        static void Main()
        {
            try
            {
                int number = GetNumber();
                Console.WriteLine("The number you have entered is: {0}", number);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("{0}: [{1}...{2}]", ex.Message, ex.Start, ex.End);
            }
            try
            {
                DateTime newDate = GetDate();
                Console.WriteLine("The date you have entered is: {0:dd.MM.yyyy}", newDate);
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("{0}: [{1:dd.MM.yyyy}...{2:dd.MM.yyyy}]", ex.Message, ex.Start, ex.End);
            }
        }
    }
}
