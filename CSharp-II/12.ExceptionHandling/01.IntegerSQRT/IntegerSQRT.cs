using System;

class IntegerSQRT
{
    private static double GetSQRT(double number)
    {
        if (number < 0)
        {
            throw new System.ArithmeticException();
        }
        return Math.Sqrt(number);
    }
    static void Main()
    {
        Console.WriteLine("This program that reads an integer number and\n" + 
            "calculates and prints its square root.");
        Console.Write("Please enter a integer number: ");
        try
        {
            int n = int.Parse(Console.ReadLine());
            double result = GetSQRT(n);
            Console.WriteLine("{0:F3}", result);
        }
        catch (System.FormatException) // Catches exception if the input is not a number
        {
            Console.WriteLine("Invalid number");
        }
        catch (System.OverflowException) // Catches exception if the input out of integer scope
        {
            Console.WriteLine("Invalid number");
        }
        catch (System.ArgumentNullException) // Catches exception if the input is null
        {
            Console.WriteLine("Invalid number");
        }
        catch (System.ArithmeticException) // Catches exception if the input is negative integer
	    {
            Console.WriteLine("Invalid number"); // This one i rise my self inside the method
	    }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }
}

