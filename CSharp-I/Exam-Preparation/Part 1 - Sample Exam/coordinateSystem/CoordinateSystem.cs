﻿using System;

class CoordinateSystem
{
    static void Main()
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());
        byte result = 0;
        if (x == 0 && y == 0)
        {
            result = 0;
        }
        else
        {
            if (x == 0)
            {
                result = 5;
            }
            if (y == 0)
            {
                result = 6;
            }
        }
        if (x > 0 && y > 0)
        {
            result = 1;
        }
        if (x > 0 && y < 0)
        {
            result = 4;
        }
        if (x < 0 && y > 0)
        {
            result = 2;
        }
        if (x < 0 && y < 0)
        {
            result = 3;
        }
        Console.WriteLine(result);
    }
}

