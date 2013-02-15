using System;
using System.Collections.Generic;
using System.Linq;

class SubsetFromSet
{
    static void Main()
    {
        int[] intArray = new int[8] { 1, 2, 3, -4, 5, -6, -7, 8 };
        int numberOfSubSets = Convert.ToInt32(Math.Pow(2, intArray.Length));
        List<int>[] subSets = new List<int>[numberOfSubSets];
        for (int i = 0; i < numberOfSubSets; i++)
        {
            subSets[i] = new List<int>();
            for (int bitIndex = 0; bitIndex < intArray.Length; bitIndex++)
            {
                int bit = i & (int)Math.Pow(2, bitIndex);
                if (bit > 0)
                {
                    subSets[i].Add(intArray[bitIndex]);
                }
            }
        }
        bool flag = false;
        for (int i = 1; i < numberOfSubSets; i++)
        {
            if (subSets[i].Sum() == 0)
            {
                flag = true;
                foreach (var index in subSets[i])
                {
                    Console.Write("{0}, ", index);
                }
                Console.WriteLine();
            }
        }
        if (!flag)
        {
            Console.WriteLine("There are no subsets with sum of zero.");
        }
    }
}

