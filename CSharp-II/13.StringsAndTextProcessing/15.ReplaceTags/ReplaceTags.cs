using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

*/



class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("This program replaces in a HTML document given as string all the tags\n" + 
            "<a href=\"…\">…</a> with corresponding tags [URL=…]…/URL].");
        Console.Write("\n Please enter text: ");
        string input = Console.ReadLine();
        string pattern = @"<a href=""(?<link>(.|\s)*?)"">(?<text>(.|\s)*?)</a>";
        string newPattern = @"[URL=${link}]${text}[/URL]";
        string result = Regex.Replace(input, pattern, newPattern);
        Console.WriteLine("\nThe result text is: {0}", result);
    }
}

