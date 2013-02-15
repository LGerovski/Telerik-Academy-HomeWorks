using System;

class Program
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] bitsArray = new int[n];
        string stringOfBits = "";
        for (int i = 0; i < n; i++)
        {
            bitsArray[i] = int.Parse(Console.ReadLine());
            stringOfBits += Convert.ToString(bitsArray[i], 2);
        }
        int ones = 0;
        int zeroes = 0;
        int currentBit = 0;
        int dancingBitsCount = 0;
        for (int i = 0; i < stringOfBits.Length; i++)
        {
            currentBit = stringOfBits[i] - 48;
            if (currentBit == 1)
            {
                ones++;
                if (zeroes == k)
                {
                    dancingBitsCount++;
                }
                zeroes = 0;
            }
            if (currentBit == 0)
            {
                zeroes++;
                if (ones == k)
                {
                    dancingBitsCount++;
                }
                ones = 0;
            }
            if (i == stringOfBits.Length - 1)
            {
                if (ones == k || zeroes== k)
                {
                    dancingBitsCount++;
                }
            }
        }
        Console.WriteLine(dancingBitsCount);
    }
}

