using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// That was the previous
// Write methods to calculate minimum, maximum, average, 
// sum and product of given set of integer numbers. 
// Use variable number of arguments.

// Modify your last program and try to make it work for any number type, 
// not just integer (e.g. decimal, float, byte, etc.). 
// Use generic method (read in Internet about generic methods in C#).

class GenericMethods
{
    static T GetMaximum<T>(params T[] elements) where T : System.IComparable<T>

    {
        T maximum = elements[0];
        foreach (var item in elements)
        {
            if (maximum.CompareTo(item) < 0)
            {
                maximum = item;
            }
        }
        return maximum;
    }
    static T GetMinimum<T>(params T[] elements) where T : System.IComparable<T>
    {
        T minimum = elements[0];
        foreach (var item in elements)
        {
            if (minimum.CompareTo(item) > 0)
            {
                minimum = item;
            }
        }
        return minimum;
    }
    static T GetAverage<T>(params T[] elements)
    {
        return GetSum(elements) / (dynamic)elements.Length;
    }
    static T GetSum<T>(params T[] elements)
    {
        dynamic sum = 0;
        foreach (var item in elements)
        {
            sum += item;
        }
        return sum;
    }
    static T GetProduct<T>(params T[] elements)
    {
        dynamic product = 1;
        foreach (var item in elements)
        {
            product *= item;
        }
        return product;
    }
    static void Main()
    {
        Console.WriteLine("This program calculates minimum, maximum, average, sum and product\n" +
            "of given set of any type of numbers. Using variable number of arguments.");
        Console.WriteLine("\nPlease enter a sequence of numbers divided by space:\n");
        //string[] input = Console.ReadLine().Split();
        //int[] array = new int[input.Length];
        //for (int i = 0; i < input.Length; i++)
        //{
        //    int.TryParse(input[i], out array[i]);
        //}
        float[] array = {2.3f, 4.56f, 1.17f };
        Console.WriteLine("\nThe sum of the sequense is: {0}", GetSum(array));
        Console.WriteLine("The minimum of the sequense is: {0}", GetMinimum(array));
        Console.WriteLine("The maximum of the sequense is: {0}", GetMaximum(array));
        Console.WriteLine("The average of the sequense is: {0}", GetAverage(array));
        Console.WriteLine("The product of the sequense is: {0}", GetProduct(array));
    }
}

