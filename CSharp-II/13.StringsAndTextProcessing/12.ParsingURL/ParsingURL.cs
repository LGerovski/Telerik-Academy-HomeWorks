using System;

// http://www.devbg.org/forum/index.php 

class URLAddress
{
    public string protocol { get; set; }
    public string server { get; set; }
    public string resource { get; set; }
}

class ParsingURL
{
    private static URLAddress ParseAddress(string input)
    {
        URLAddress url = new URLAddress();
        string[] parsedAddress = input.Split(':');
        url.protocol = parsedAddress[0];
        parsedAddress[1] = parsedAddress[1].Substring(2);
        int separator = parsedAddress[1].IndexOf('/');
        if (separator != -1)
        {
            url.server = parsedAddress[1].Substring(0, separator);
            url.resource = parsedAddress[1].Substring(separator).Trim();
        }
        else
        {
            url.server = parsedAddress[1];
        }
        return url;
    }
    static void Main()
    {
        Console.WriteLine("This program parses an URL address given in the format:");
        Console.WriteLine("[protocol]://[server]/[resource]");
        Console.Write("\nPlease enter URL address to be parsed: ");
        string input = Console.ReadLine();
        URLAddress currentAddress = ParseAddress(input);
        Console.WriteLine("\n[protocol] = \"{0}\"", currentAddress.protocol);
        Console.WriteLine("[server] = \"{0}\"", currentAddress.server);
        Console.WriteLine("[resource] = \"{0}\"\n", currentAddress.resource);
    }
}

