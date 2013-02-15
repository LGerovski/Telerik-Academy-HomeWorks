using System;

class Lines
{
    static void Main()
    {
        byte[] byteArray = new byte[8];
        for (int i = 0; i < 8; i++)
        {
            byteArray[i] = byte.Parse(Console.ReadLine());
        }
        int currentCount = 0; 
        int maxCount = 0;
        int numberOfCounts = 0;
        int mask = 1;
        for (int row = 0; row < 8; row++)
        {
            currentCount = 0;
            for (int column = 0; column < 8; column++)
            {
                mask = 1;
                mask = mask << column;
                if ((byteArray[row] & mask) >> column == 1)
                {
                    currentCount++;
                }
                if (((byteArray[row] & mask) >> column == 0 || column == 7) && (currentCount > 0))
                {
                    if (maxCount < currentCount)
                    {
                        maxCount = currentCount;
                        numberOfCounts = 1;
                    }
                    else if (maxCount == currentCount)
                    {
                        numberOfCounts++;
                    }
                    currentCount = 0;
                }
            }
        }
        int verticalCount = numberOfCounts; 
        for (int row = 0; row < 8; row++)
        {
            currentCount = 0;
            mask = 1;
            mask = mask << row;
            for (int column = 0; column < 8; column++)
            {
                if ((byteArray[column] & mask) >> row == 1)
                {
                    currentCount++;
                }
                if (((byteArray[column] & mask) >> row == 0 || column == 7) && (currentCount > 0))
                {
                    if (maxCount < currentCount)
                    {
                        maxCount = currentCount;
                        numberOfCounts = 1;
                    }
                    else if (maxCount == currentCount)
                    {
                        numberOfCounts++;
                    }
                    currentCount = 0;
                }
            }
        }
        if (maxCount == 1)
        {
            Console.WriteLine(maxCount);
            Console.WriteLine(verticalCount);
        }
        else
        {
            Console.WriteLine(maxCount);
            Console.WriteLine(numberOfCounts);
        }
        
    }
}

