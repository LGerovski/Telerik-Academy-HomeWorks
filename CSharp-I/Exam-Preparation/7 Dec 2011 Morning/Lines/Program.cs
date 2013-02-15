using System;

class Program
{
    static void Main()
    {
        byte[] byteArray = new byte[8];
        for (int i = 0; i < 8; i++)
        {
            byteArray[i] = byte.Parse(Console.ReadLine());
        }
        int currentCount = 0; 
        int newCount = 0;
        int numberOfCounts = 0;
        int mask = 1;
        for (int row = 0; row < 8; row++)
        {
            mask = 1;
            currentCount = 0;
            for (int column = 0; column < 8; column++)
            {
                if ((byteArray[row] & mask) >> column == 1)
                {
                    currentCount++;
                }
                if (((byteArray[row] & mask) >> column == 0 || column == 7) && (currentCount > 0))
                {
                    if (newCount < currentCount)
                    {
                        newCount = currentCount;
                        numberOfCounts = 1;
                    }
                    else if (newCount == currentCount)
                    {
                        numberOfCounts++;
                    }
                    currentCount = 0;
                }
                mask = mask << 1;
            }
        }
        mask = 1;
        for (int row = 0; row < 8; row++)
        {
            currentCount = 0;
            for (int column = 0; column < 8; column++)
            {
                if ((byteArray[column] & mask) >> row == 1)
                {
                    currentCount++;
                }
                if (((byteArray[column] & mask) >> row == 0 || column == 7) && (currentCount > 0))
                {
                    if (newCount < currentCount)
                    {
                        newCount = currentCount;
                        numberOfCounts = 1;
                    }
                    else if (newCount == currentCount)
                    {
                        numberOfCounts++;
                    }
                    currentCount = 0;
                }
            }
            mask = mask << 1;
        }
        Console.WriteLine(newCount);
        Console.WriteLine(numberOfCounts);
    }
}

