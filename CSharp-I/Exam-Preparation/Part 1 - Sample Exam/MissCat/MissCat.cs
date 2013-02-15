using System;

class MissCat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] catArray = new int[10];
        int userInput;
        for (int i = 0; i < n; i++)
        {
            userInput = int.Parse(Console.ReadLine());
            catArray[userInput - 1]++;
        }
        int winner = 0;
        int winningPoints = 0;
        for (int i = 0; i < 10; i++)
        {
            if (catArray[i] > winningPoints)
            {
                winningPoints = catArray[i];
                winner = i+1;
            }
        }
        Console.WriteLine(winner);
    }
}

