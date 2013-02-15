using System;

class FighterAttack
{
    private static int plantX1, plantY1, plantX2, plantY2;

    private static int GetDamage(int x, int y, int damage)
    {
        if (x >= plantX1 && x <= plantX2 && y >= plantY1 && y <= plantY2)
        {
            return damage;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        plantX1 = int.Parse(Console.ReadLine());
        plantY1 = int.Parse(Console.ReadLine());
        plantX2 = int.Parse(Console.ReadLine());
        plantY2 = int.Parse(Console.ReadLine());
        int FighterX = int.Parse(Console.ReadLine());
        int FighterY = int.Parse(Console.ReadLine());
        int Distance = int.Parse(Console.ReadLine());

        FighterX = FighterX + Distance;
        if (plantX1 > plantX2)
        {
            plantX1 = plantX1 + plantX2;
            plantX2 = plantX1 - plantX2;
            plantX1 = plantX1 - plantX2;
        }
        if (plantY1 > plantY2)
        {
            plantY1 = plantY1 + plantY2;
            plantY2 = plantY1 - plantY2;
            plantY1 = plantY1 - plantY2;
        }
        int damageCenter = GetDamage(FighterX, FighterY, 100);
        int damageFront = GetDamage(FighterX + 1, FighterY, 75);
        int damageUp = GetDamage(FighterX, FighterY + 1, 50);
        int damageDown = GetDamage(FighterX, FighterY - 1, 50);
        Console.WriteLine("{0}%", damageCenter + damageFront + damageUp + damageDown);
    }
}

