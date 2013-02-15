using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SolvingTasks
{
    static int GetNumber()
    {
        int size = 0;
        Console.Write("\nPlease enter a positive number N = ");
        int.TryParse(Console.ReadLine(), out size);
        return size;
    }
    static string GetReversedNumber(int number)
    {
        string getInput = number.ToString();  // converting the input to string
        char[] array = getInput.ToCharArray(); // converting the string to char array
        Array.Reverse(array);                 // reversing the array elements
        getInput = new string(array);           // converting the array back to string
        return getInput;                        // returning the string, there is no need to convert it back to decimal
    }
    private static void ReverseDigits()
    {
        int input = GetNumber();
        if (input <= 0)
        {
            Console.WriteLine("\nThe decimal number should be positive");
        }
        else
        {
            Console.WriteLine("\nThe reversed number is: {0}", GetReversedNumber(input));
        }
    }
    static int[] GetSequence()
    {
        Console.WriteLine("\nPlease enter a sequence of integers each separated with space:\n");
        string[] input = Console.ReadLine().Split();
        if (input.Length == 1 && input[0] == "")
        {
            return new int[0];
        }
        else
        {
            int[] array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                int.TryParse(input[i], out array[i]);
            }
            return array;
        }
    }
    private static void CalculateAverage()
    {
        int[] array = GetSequence();
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        if (array.Length == 0)
        {
            Console.WriteLine("The sequence should not be empty.");
        }
        else
        {
            Console.WriteLine("The average of the sequence is: {0}", sum / array.Length);
        }
    }
    private static void SolveEquation()
    {
        Console.Write("\nPlease enter coeficient \"a\": ");
        int a;
        int b;
        int.TryParse(Console.ReadLine(), out a);
        if (a == 0)
        {
            Console.WriteLine("\"a\" should be integer and not equal to 0");
        }
        else
        {
            Console.Write("\nPlease enter coeficient \"b\": ");
            int.TryParse(Console.ReadLine(), out b);
            if (b != 0)
            {
                Console.WriteLine("The solution of the equation {0} * x + {1} = 0 is: {2:F2}", a, b, (-b) / (decimal)a);
            }
            else
            {
                Console.WriteLine("Every number could be solution for the equation.");
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("This program can solve the following tasks:\n");
        Console.WriteLine("1. Reverse the digits of a number.");
        Console.WriteLine("2. Calculates the average of a sequence of integers.");
        Console.WriteLine("3. Solves a linear equation a * x + b = 0.");
        Console.WriteLine("0. If you like to exit the program press Zero.");
        string input = null;
        while (input != "0")
        {
            Console.Write("\nPlease choose the task you would like to get solved (1/2/3/0): ");
            input = Console.ReadLine();
            switch (input)
            {
                case "1": ReverseDigits();
                    break;
                case "2": CalculateAverage();
                    break;
                case "3": SolveEquation();
                    break;
                default:
                    break;
            }
        }
    }
}

