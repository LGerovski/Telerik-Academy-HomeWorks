using System;

class StringsDescription
{
    static void Main()
    {
        Console.WriteLine("Strings are sequence of Characters.");
        Console.WriteLine("Each character in a string is a Unicode symbol.");
        Console.WriteLine("Strings are initialized by the key word \"string\" in C#.");
        Console.WriteLine("Strings can also be initialized using the class System.String.");
        Console.WriteLine("For Example --> string s = \"Hello, C#\".");
        Console.WriteLine("String objects are immutable, meaning once initialized they cannot be changed.");
        Console.WriteLine("Strings are stored in the dynamic memory (managed heap).");
        Console.WriteLine("System.String is reference type.");
        Console.WriteLine("String objects are like arrays of characters (char[]).");
        Console.WriteLine("Strings have fixed length (String.Length).");
        Console.WriteLine("The elements of a string can be accesses directly by index.");
        Console.WriteLine("The index is in the range [0...Length-1].");
        Console.WriteLine("Before initializing a string variable has \"null\" value.");
        Console.WriteLine("Strings can be initialized by:");
        Console.WriteLine("Assigning a string literal to the string variable.");
        Console.WriteLine("Assigning the value of another string variable.");
        Console.WriteLine("Assigning the result of operation of type string.");
        Console.WriteLine("\nMain methods used with strings are:");
        Console.WriteLine("Caution - All methods that change the string actually return\n" + 
            "new string as a result.");
        Console.WriteLine("Compare - Comparing two strings.");
        Console.WriteLine("Equals - to check if two strings are equal.");
        Console.WriteLine("Concat - to glue two strings together.");
        Console.WriteLine("IndexOf - First occurrence of character or substring.");
        Console.WriteLine("LastIndexOf - Last occurrence of character or substring.");
        Console.WriteLine("Substring - extracts substring from given string.");
        Console.WriteLine("Split - splits strings by given criteria.");
        Console.WriteLine("Replace - replaces certain substring with another in a string.");
        Console.WriteLine("Remove - deletes part of a string and produces new string as result.");
        Console.WriteLine("ToLower - changes all letters in a string to lower case.");
        Console.WriteLine("ToUpper - changes all letters in a string to upper case.");
        Console.WriteLine("Trim - removes certain characters from string.");
        Console.WriteLine("StringBuilder is a class for fast string building.");
        Console.WriteLine("Methods used by Stringbuilder class: Append, Remove, Insert, Replace.");
    }
}

