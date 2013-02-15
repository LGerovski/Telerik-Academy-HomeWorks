using System;

class ObjectToString
{
    static void Main()
    {
        string helloString = "Hello";
        string worldString = "World";
        object helloWorldObject = helloString + " " + worldString;
        string helloWorldString = helloWorldObject.ToString();
    }
}

