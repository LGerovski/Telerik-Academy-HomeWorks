using System;

class FallDown
{
    static void Main()
    {
        int[] array = new int[8];
        for (int i = 0; i < 8; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int mask = 1;
        for (int itterations = 0; itterations < 7; itterations++)
		{
            for (int rowNumber = 7; rowNumber > itterations; rowNumber--)
            {
                for (int colNumber = 0; colNumber < 8; colNumber++)
                {
                    if (((array[rowNumber] & mask) == 0) && ((array[rowNumber - 1] & mask) >> colNumber) == 1)
                    {
                        array[rowNumber] = array[rowNumber] ^ mask;
                        array[rowNumber - 1] = array[rowNumber - 1] ^ mask;
                    }
                    mask = mask << 1;
                }
                mask = 1;
            }
		}
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

