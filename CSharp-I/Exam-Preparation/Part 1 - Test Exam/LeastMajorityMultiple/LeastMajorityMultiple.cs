using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int[] a = new int[5]; 
        for (int i = 0; i < 5; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(a);
        int count = 0;
        int number = a[2];
        bool flag = true;
        while (flag)
        {
            for (int j = 0; j < 5; j++)
            {
                if (number % a[j] == 0)
                {
                    count++;
                    if (count > 2)
                    {
                        Console.WriteLine(number);
                        flag = false;
                        break;
                    }
                }
            }
            number++;
            count = 0;
        }
       
    }
}

