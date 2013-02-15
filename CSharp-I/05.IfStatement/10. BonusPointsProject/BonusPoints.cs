using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BonusPoints
{
    public static void PrintBonusPoints(int points, int bonusCoeficient)
    {
        Console.WriteLine("Bonus points are: {0}", points*bonusCoeficient);
    }
    static void Main()
    {
        Console.Write("Input current points: ");
        int currentPoints;
        int.TryParse(Console.ReadLine(), out currentPoints);
        switch (currentPoints)
        {
            case 1:
            case 2:
            case 3: PrintBonusPoints(currentPoints, 10); break;
            case 4:
            case 5:
            case 6: PrintBonusPoints(currentPoints, 100); break;
            case 7:
            case 8:
            case 9: PrintBonusPoints(currentPoints, 1000); break;
            
            default: Console.WriteLine("Wrong input!"); break;
        }
    }
}

