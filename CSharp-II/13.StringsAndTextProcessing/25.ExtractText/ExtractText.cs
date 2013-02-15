using System;
using System.Text.RegularExpressions;

/*
<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skillful .NET software engineers.</p></body>
</html>

*/

class ExtractText
{
    static void Main()
    {
        Console.WriteLine("This program extracts from given HTML text its title (if available),\n" + 
            "and its body text without the HTML tags.");
        Console.Write("\nPlease enter HTML text: ");
        string text = null;
        string input = null;
        do
        {
            input = Console.ReadLine();
            text += input;
        } while (input != "" && input != null);
        string pattern = string.Format(@"<.*?>");
        text = Regex.Replace(text, pattern, "");
        Console.WriteLine("\n{0}", text);
    }
}

