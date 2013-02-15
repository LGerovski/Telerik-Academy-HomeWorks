using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceCalculations
{
    static int GetMaximum(params int[] elements)
    {
        int maximum = int.MinValue;
        foreach (var item in elements)
        {
            if (maximum < item)
            {
                maximum = item;
            }
        }
        return maximum;
    }
    static int GetMinimum(params int[] elements)
    {
        int minimum = int.MaxValue;
        foreach (var item in elements)
        {
            if (minimum > item)
            {
                minimum = item;
            }
        }
        return minimum;
    }
    static int GetAverage(params int[] elements)
    {
        int average = 0;
        foreach (var item in elements)
        {
            average += item;
        }
        return average / elements.Length;
    }
    static int GetSum(params int[] elements)
    {
        int sum = 0;
        foreach (var item in elements)
        {
            sum += item;
        }
        return sum;
    }
    static long GetProduct(params int[] elements)
    {
        long product = 1;
        foreach (var item in elements)
        {
            product *= item;
        }
        return product;
    }
    static void Main()
    {
        Console.WriteLine("This program calculates minimum, maximum, average, sum and product\n" + 
            "of given set of integer numbers. Using variable number of arguments.");
        Console.WriteLine("\nPlease enter a sequence of integers divided by space:\n");
        string[] input = Console.ReadLine().Split();
        int[] array = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            int.TryParse(input[i], out array[i]);
        }
        Console.WriteLine("\nThe sum of the sequense is: {0}", GetSum(array));
        Console.WriteLine("The minimum of the sequense is: {0}", GetMinimum(array));
        Console.WriteLine("The maximum of the sequense is: {0}", GetMaximum(array));
        Console.WriteLine("The average of the sequense is: {0}", GetAverage(array));
        Console.WriteLine("The product of the sequense is: {0}", GetProduct(array));
    }
}

