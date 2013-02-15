using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AddingLongIntegers
{
    static int[] GetSum(int[] arrayA, int[] arrayB)
    {
        int maxLength = Math.Max(arrayA.Length, arrayB.Length);
        int[] arrayC = new int[maxLength + 1];
        int carry = 0;
        int minLength = (int)Math.Min(arrayA.Length, arrayB.Length);
        for (int i = 0; i < minLength; i++)
        {
            carry = (arrayA[i] + arrayB[i]) / 10;
            arrayC[i] += ((arrayA[i] + arrayB[i]) % 10);
            arrayC[i + 1] = carry;
        }
        for (int i = minLength; i < maxLength; i++)
		{
            if (minLength > arrayA.Length)
            {
                arrayC[i] += arrayB[i];
            }
            else
            {
                arrayC[i] += arrayA[i];
            }
		}
        return arrayC;
    }
    static void PrintArray(int[] array)
    {
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] arrayA = {1, 5, 8, 2, 3, 4, 6, 7, 3, 4, 5, 2, 1, 9 };
        int[] arrayB = {2, 3, 6, 5, 7, 8, 9, 2, 3, 5, 1 };
        int[] ArrayC = GetSum(arrayA, arrayB);
        PrintArray(ArrayC);
        Console.WriteLine();
    }
}

