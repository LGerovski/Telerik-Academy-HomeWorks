using System;

class AstrologicalDigits
{
    static void Main()
    {
        string stringNumber = Console.ReadLine();
        stringNumber = stringNumber.Replace(".", "");
        stringNumber = stringNumber.Replace("-", "");
        int sum = 0;
        for (int i = 0; i < stringNumber.Length; i++)
        {
            sum += stringNumber[i] - 48;
        }
        while (sum > 9)
        {
            stringNumber = sum.ToString();
            sum = 0;
            for (int i = 0; i < stringNumber.Length; i++)
            {
                sum += stringNumber[i] - 48;
            }
        }
        Console.WriteLine(sum);
    }
}

