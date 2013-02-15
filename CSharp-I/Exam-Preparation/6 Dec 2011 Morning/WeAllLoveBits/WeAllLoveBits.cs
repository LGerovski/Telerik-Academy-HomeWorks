using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        string[] stringArray = new string[n];
        int intToBinary = 0;
        for (int i = 0; i < n; i++)
        {
            intToBinary = array[i];
            while (intToBinary > 0)
            {
                stringArray[i] = (intToBinary % 2).ToString() + stringArray[i];
                intToBinary /= 2;
            }
        }
        for (int i = 0; i < n; i++)
        {
            array[i] = 0;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < stringArray[i].Length; j++)
            {
                int temp = Convert.ToInt32(stringArray[i][j]) - 48;
                array[i] += Convert.ToInt32(temp * Math.Pow(2, j));
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

