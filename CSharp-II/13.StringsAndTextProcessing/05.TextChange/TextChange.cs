using System;
using System.Text;

// Sample text, could be used for input.
// We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

class TextChange
{
    static void Main()
    {
        Console.WriteLine("This program changes the text in all regions\n" + 
            "surrounded by the tags <upcase> and </upcase> to uppercase.");
        Console.Write("Please enter text: ");
        string input = Console.ReadLine();
        int begginingIndex = 0;
        int index = -1;
        int startIndex = -1;
        int endIndex = -1;
        StringBuilder upperString = new StringBuilder();
        while (true)
        {
            startIndex = input.IndexOf('>', index + 1);
            index = startIndex;
            endIndex = input.IndexOf('<', index + 1);
            index = endIndex + 8;
            if (startIndex == -1)
            {
                int lastIndex = input.LastIndexOf('>') + 1;
                if (lastIndex < input.Length)
                {
                    upperString.Append(input.Substring(lastIndex));
                }
                break;
            }
            upperString.Append(input.Substring(begginingIndex, (startIndex - 7) - begginingIndex));
            upperString.Append(input.Substring(startIndex + 1, endIndex - startIndex - 1).ToUpper());
            begginingIndex = endIndex + 9;
        }
        Console.WriteLine("\n{0}", upperString);
    }
}

