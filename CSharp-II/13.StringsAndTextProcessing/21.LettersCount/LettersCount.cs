using System;
using System.Collections.Generic;
using System.Linq;

// Singomakers are proud to present this Epic Label Sampler containing Samples from five of the bestselling sample packs from Singomakers label. Here you will find samples for such styles like Swedish House, Big Room, Dubstep, Drum & Bass, Techno, Funky House, Electro House.

class LettersCount
{
    static void Main()
    {
        Console.WriteLine("This program reads a string from the console and prints all different letters\n" + 
            "in the string along with information how many times each letter is found. ");
        Console.Write("\nPlease enter a string to be read: ");
        string input = Console.ReadLine();
        Console.WriteLine();
        Dictionary<char, int> letters = new Dictionary<char, int>();
        foreach (var item in input)
        {
            int value;
            if (letters.TryGetValue(item, out value))
            {
                letters[item] = value + 1;
            }
            else
            {
                letters.Add(item, 1);
            }
        }
        letters = letters.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
        foreach (var item in letters)
        {
            if ((item.Key >= 'A' && item.Key <= 'Z') || (item.Key >= 'a' && item.Key <= 'z'))
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }
    }
}

