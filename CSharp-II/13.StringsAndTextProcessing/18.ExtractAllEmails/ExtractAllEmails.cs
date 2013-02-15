using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/*
 * 
Valid email addresses niceandsimple@example.com very.common@example.com a.little.lengthy.but.fine@dept.example.com disposable.style.email.with+symbol@example.com user@[IPv6:2001:db8:1ff::a0b:dbd0] "much.more unusual"@example.com
"very.unusual.@.unusual.com"@example.com "very.(),:;<>[]\".VERY.\"very@\\ \"very\".unusual"@strange.example.com postbox@com (top-level domains are valid hostnames) admin@mailserver1 (local domain name with no TLD)
!#$%&'*+-/=?^_`{}|~@example.org "()<>[]:,;@\\\"!#$%&'*+-/=?^_`{}| ~.a"@example.org " "@example.org (space between the quotes)

[edit] Invalid email addresses
Abc.example.com (an @ character must separate the local and domain parts)
A@b@c@example.com (only one @ is allowed outside quotation marks)
a"b(c)d,e:f;g<h>i[j\k]l@example.com (none of the special characters in this local part are allowed outside quotation marks)
just"not"right@example.com (quoted strings must be dot separated, or the only element making up the local-part)
this is"not\allowed@example.com (spaces, quotes, and backslashes may only exist when within quoted strings and preceded by a backslash)
this\ still\"not\\allowed@example.com (even if escaped (preceded by a backslash), spaces, quotes, and backslashes must still be contained by quotes)

*/



class ExtractAllEmails
{
    static void Main()
    {
        Console.WriteLine("This program extracts all email addresses from given text.");
        Console.Write("\nPlease enter some text: ");
        string input = Console.ReadLine();
        List<string> listWithEmails = new List<string>();
        string pattern = @"^([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})$";
        Match match = Regex.Match(input, pattern);
        if (match.Success)
        {
            while (match.Success)
            {
                listWithEmails.Add(match.ToString());
                match = match.NextMatch();
            }
            Console.WriteLine("\nValid email addresses found in the text:\n");
            foreach (var item in listWithEmails)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("\nThere are no valid email addresses in this text.");
        }
    }
}

