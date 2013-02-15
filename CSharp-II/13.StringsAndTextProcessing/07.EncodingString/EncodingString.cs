using System;
using System.Text;

class EncodingString
{
    static string EncodeText(string text, string key)
    {
        int keyindex = 0;
        StringBuilder encryptedText = new StringBuilder();
        foreach (var item in text)
        {
            encryptedText.Append((char)(item ^ key[keyindex++]));
            if (keyindex >= key.Length)
            {
                keyindex = 0;
            }
        }
        return encryptedText.ToString();
    }
    static void Main()
    {
        Console.WriteLine("This program encodes and decodes a string using given encryption key (cipher).");
        Console.Write("\nPlease enter a string to be encoded: ");
        string input = Console.ReadLine();
        Console.Write("\nPlease enter an encryption key: ");
        string key = Console.ReadLine();
        input = EncodeText(input, key);
        Console.WriteLine("Encripted string: {0}", input);
        input = EncodeText(input, key);
        Console.WriteLine("Decripted string: {0}", input);
    }
}

