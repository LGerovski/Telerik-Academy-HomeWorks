using System;

class ShipDamage
{
    static int shipX1, shipY1, shipX2, shipY2;
    static int horizont;
    private static int GetPResult(int x, int y)
    {
        bool borderX = false, insideX = false;
        bool borderY = false, insideY = false;
        int result = 0;
        if ( x == shipX1 || x == shipX2)
        {
            borderX = true;
        }
        else if ( x > shipX1 && x < shipX2)
        {
            insideX = true;
        }
        if (y == shipY1 || y == shipY2)
        {
            borderY = true;
        }
        else if (y > shipY1 && y < shipY2)
        {
            insideY = true;
        }
        if (borderX && borderY)
        {
            result = 25;
        }
        else if ((borderX && insideY) || (insideX && borderY))
        {
            result = 50;
        }
        else if (insideX && insideY)
        {
            result = 100;
        }
        return result;
    }
    static void Main()
    {
        int bomb1X, bomb1Y;
        int bomb2X, bomb2Y;
        int bomb3X, bomb3Y;

        shipX1 = int.Parse(Console.ReadLine());
        shipY1 = int.Parse(Console.ReadLine());
        shipX2 = int.Parse(Console.ReadLine());
        shipY2 = int.Parse(Console.ReadLine());
        horizont = int.Parse(Console.ReadLine());
        bomb1X = int.Parse(Console.ReadLine());
        bomb1Y = int.Parse(Console.ReadLine());
        bomb2X = int.Parse(Console.ReadLine());
        bomb2Y = int.Parse(Console.ReadLine());
        bomb3X = int.Parse(Console.ReadLine());
        bomb3Y = int.Parse(Console.ReadLine());

        bomb1Y = -1*(bomb1Y - 2*horizont);
        bomb2Y = -1*(bomb2Y - 2*horizont);
        bomb3Y = -1*(bomb3Y - 2*horizont);
        if (shipX1 > shipX2)
        {
            shipX1 = shipX1 + shipX2;
            shipX2 = shipX1 - shipX2;
            shipX1 = shipX1 - shipX2;
        }
        if (shipY1 > shipY2)
        {
            shipY1 = shipY1 + shipY2;
            shipY2 = shipY1 - shipY2;
            shipY1 = shipY1 - shipY2;
        }

        Console.WriteLine("{0}%", GetPResult(bomb1X, bomb1Y) + GetPResult(bomb2X, bomb2Y) + GetPResult(bomb3X, bomb3Y));

    }
}

