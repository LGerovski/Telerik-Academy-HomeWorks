using System;

class IsPrime
{
    private static void PrintMessage(bool prime)
    {
        Console.WriteLine("The number you have entered is prime? -> {0}.", prime);
    }
    static void Main()
    {
        byte intNumber = 0;
        bool prime = true;

        Console.Write("Enter a Integer number valid interval [0..100]: ");
        if (byte.TryParse(Console.ReadLine(), out intNumber) && intNumber <= 100)
        {
            for (int i = 2; i <= Math.Sqrt(intNumber); i++)
            {
                if (intNumber % i == 0)
                {
                    prime = false;
                }
            }
            if (intNumber == 0 || intNumber == 1)
            {
                prime = false;
            }
            PrintMessage(prime);
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }

    }
}

