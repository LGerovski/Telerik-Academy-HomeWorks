using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateSurface
{
    private static void TwoSidesAndAngle()
    {
        throw new NotImplementedException();
    }

    private static void ThreeSides()
    {
        throw new NotImplementedException();
    }

    private static void SideAndAltitude()
    {
        throw new NotImplementedException();
    }



    static void Main()
    {
        Console.WriteLine("This program calculates the surface of a triangle by given:\n");
        Console.WriteLine("1. Side and an altitude to it;\n" + 
            "2. Three sides;\n" + 
            "3. Two sides and an angle between them.\n");
        Console.Write("Choose how you want to calculate it (1 / 2 / 3): ");
        byte input;
        if (byte.TryParse(Console.ReadLine(), out input))
        {
            switch (input)
            {
                case 1: SideAndAltitude();
                    break;
                case 2: ThreeSides();
                    break;
                case 3: TwoSidesAndAngle();
                    break;
                default: Console.WriteLine("\nWrong input.\n");
                    break;
            }
        }
        else
        {
            Console.WriteLine("\nWrong input.\n");
        }

    }

   
}

