using System;
using System.Collections.Generic;
using System.Linq;

class Subsets
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long[] array = new long[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = long.Parse(Console.ReadLine());
        }

        int numberOfSubSets = Convert.ToInt32(Math.Pow(2, array.Length));
        List<long>[] subSets = new List<long>[numberOfSubSets];
        int mask = 1;
        for (int i = 0; i < numberOfSubSets; i++)
        {
            subSets[i] = new List<long>();
            for (int bitIndex = 0; bitIndex < array.Length; bitIndex++)
            {
                mask = 1;
                mask = mask << bitIndex;
                int bit = i & mask;
                if (bit > 0)
                {
                    subSets[i].Add(array[bitIndex]);
                }
            }
        }
        int subsetsCount = 0;
        for (int i = 1; i < numberOfSubSets; i++)
        {
            if (subSets[i].Sum() == s)
            {
                subsetsCount++;
            }
        }
        Console.WriteLine(subsetsCount);

    }
}

