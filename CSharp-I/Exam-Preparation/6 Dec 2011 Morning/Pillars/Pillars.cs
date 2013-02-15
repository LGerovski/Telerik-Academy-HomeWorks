using System;

class Pillars
{
    static void Main()
    {
        int[] numbers = new int[8];
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int mask;
        int[] digits = new int[8];
        for (int i = 0; i < 8; i++)
        {
            mask = 1;
            mask = mask << i;
            for (int j = 0; j < 8; j++)
            {
                if (((numbers[j] & mask) >> i) == 1)
                {
                    digits[i]++;
                }
            }
        }
        int sum = 0;
        for (int i = 0; i < 8; i++)
        {
            sum += digits[i];
        }
        int sumLeft;
        int sumRight;
        bool foundPillar = false;
        int index;
        int bitsCount = 0;
        for (index = 7; index >= 0; index--)
        {
            sumLeft = 0;
            sumRight = 0;
            for (int i = 7; i > index; i--)
            {
                sumLeft += digits[i];
            }
            for (int j = 0; j < index; j++)
            {
                sumRight += digits[j];
            }
            if (sumLeft == sumRight)
            {
                foundPillar = true;
                bitsCount = sumLeft;
                break;
            }
        }
        if (foundPillar)
        {
            Console.WriteLine(index);
            Console.WriteLine(bitsCount);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

