using System;
using System.Collections.Generic;

class NFactorial
{
    static int[] MultiplyNumbers(int[] array, int number)
    {
        int[] product = new int[1];
        List<int> productList = new List<int>();
        int carry = 0;
        for (int i = 0; i < array.Length; i++)
        {
            productList.Add(((array[i] * number) + carry) % 10);
            carry = (((array[i] * number) + carry) / 10);
        }
        while (carry > 0)
        {
            productList.Add(carry % 10);
            carry /= 10;
        }
        product = productList.ToArray();
        return product;
    }
    static string PrintNumber(int[] factorial)
    {
        string s = null;
        for (int i = factorial.Length - 1; i >= 0; i--)
        {
            s += factorial[i];
        }
        return s;
    }
    static void Main()
    {
        Console.WriteLine("This program calculates n! for each n in the range [1..100].");
        int[] factorial = { 1 };
        for (int i = 1; i <= 100; i++)
        {
            factorial = MultiplyNumbers(factorial, i);
            Console.WriteLine("{0}! = {1}", i, PrintNumber(factorial));
        }
    }
}

