using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AccuracyCalculation
{
    static void Main()
    {
        int i = 1;
        double sum = 0;
        bool flag = true;
        while (flag)
        {
            if (((sum + (1.0 / i)) - sum) < 0.001)
            {
                flag = false;
            }
            sum += (1.0 / i);
            i++;
        }
        Console.WriteLine(sum);
    }
}

