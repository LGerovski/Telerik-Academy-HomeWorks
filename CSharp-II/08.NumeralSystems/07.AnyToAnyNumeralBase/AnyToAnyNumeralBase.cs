using System;

class AnyToAnyNumeralBase
{
    static int GetDecimal(string number, int initialBase)
    {
        int decimalNumber = 0;
        char[] charArray = number.ToCharArray();
        Array.Reverse(charArray);
        number = new string(charArray);
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] < 58)
            {
                decimalNumber += (int)((number[i] - '0') * Math.Pow(initialBase, i));
            }
            else if (number[i] < 95)
            {
                decimalNumber += (int)((number[i] - 55) * Math.Pow(initialBase, i));
            }
            else
            {
                decimalNumber += (int)((number[i] - 87) * Math.Pow(initialBase, i));
            }
        }
        return decimalNumber;
    }
    static string getNewBase(int number, int newBase)
    {
        string result = null;
        while (number > 0)
	    {
            int reminder = number % newBase;
            if (reminder > 9)
            {
                result += (char)(reminder + 55);
            }
            else
            {
                result += reminder;
            }
            number = number / newBase;
	    }
        char[] charArray = result.ToCharArray();
        Array.Reverse(charArray);
        result = new string(charArray);
        return result;    
    }
    static void Main()
    {
        Console.WriteLine("This program converts from any numeral system of given base s\n" + 
            "to any other numeral system of base d (2 ≤ s, d ≤  16).");
        Console.Write("\nPlease enter numeral base from which you want to convert: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Please enter numeral base to which you want to convert: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number you want to convert: ");
        string number =Console.ReadLine();
        int decimalNumber = GetDecimal(number, s);
        string result = getNewBase(decimalNumber, d);
        Console.WriteLine("\nThe representation of the number is: {0}\n", result);
    }
}

