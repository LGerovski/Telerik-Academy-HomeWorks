using System;

class PrintAllCards
{
    static void Main()
    {
        string[] allCards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        string[] cardsColors = { "Spades", "Hearts", "Diamonds", "Clubs" };
        for (int i = 0; i < allCards.Length; i++)
        {
            for (int j = 0; j < cardsColors.Length; j++)
            {
                Console.Write("{0,2} - {1} ", allCards[i], cardsColors[j]);
            }
            Console.WriteLine();
        }
    }
}

