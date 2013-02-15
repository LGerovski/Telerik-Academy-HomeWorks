using System;

class BinaryDigits
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long[] uintArray = new long[n];
        string[] stringArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            uintArray[i] = long.Parse(Console.ReadLine());
            stringArray[i] = Convert.ToString(uintArray[i], 2);
            if (b == 0)
            {
                stringArray[i] = stringArray[i].Replace("1", "");
            }
            else
            {
                stringArray[i] = stringArray[i].Replace("0", "");
            }
            
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(stringArray[i].Length);
        }
    } 
}

