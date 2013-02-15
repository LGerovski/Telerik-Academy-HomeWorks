using System;

class PrintNumber
{
    private static string[] ones = new string[] {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    private static string[] teens = new string[] {"ten", "eleven", "twelve", "thirteen", "fourteen", "fiftheen", "sixteen", "seventeen", "eighteen", "nineteen"};
    private static string[] tens = new string[] {"twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

    private static string AddHundreds(int number)
    {
        string hundreds = "";
        hundreds += ones[(number / 100) - 1];
        hundreds += " ";
        hundreds += "hundred";
        return hundreds;
    }
    private static string AddTeens(int number)
    {
        string teen = "";
        teen += teens[number];
        return teen;
    }
    private static string AddTens(int number)
    {
        string ten = "";
        ten += tens[number-2];
        return ten;
    }
    private static string AddOnes(int number)
    {
        string one = "";
        one += ones[number-1];
        return one;
    }
    
    static void Main()
    {
        Console.WriteLine("This program converts a number in the range [0...999] " +
            "\nto a text corresponding to its English pronunciation.");
        int number = 0;
        
        string stringNumber = "";
        Console.Write("\nInput a number between [0...999]: ");
        if (int.TryParse(Console.ReadLine(), out number) && number >= 0 && number <= 999)
	    {
            if (number > 99)
            {
                stringNumber += AddHundreds(number);
            }
            int workingNumber = number / 10;
            workingNumber %= 10;
            if (workingNumber == 1)
            {
                if (number > 99)
                {
                    stringNumber += " and ";
                }
                stringNumber += AddTeens(number%10);
            }
            else
            {
                if (workingNumber > 1)
                {
                    if (number > 99)
                    {
                        stringNumber += " and ";
                    }
                    stringNumber += AddTens(workingNumber);
                }
                if (number%10 > 0)
                {
                    if (number > 99)
                    {
                        if (workingNumber == 0)
                        {
                            stringNumber += " and ";
                        }
                        else
                        {
                            stringNumber += " ";
                        }
                    }
                    if (number <= 99 && workingNumber > 0)
                    {
                        stringNumber += " ";
                    }
                    stringNumber += AddOnes(number%10);
                }
            }
            if (number == 0)
            {
                stringNumber = "zero";
            }
            stringNumber = char.ToUpper(stringNumber[0]) + stringNumber.Substring(1);
            Console.WriteLine("\n{0}\n", stringNumber);
	    }
        else
	    {
            Console.WriteLine("\nWrong Input.\n");
	    }
              
       
    }
}

