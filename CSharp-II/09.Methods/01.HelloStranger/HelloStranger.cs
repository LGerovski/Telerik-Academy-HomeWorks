using System;

class HelloStranger
{
    static void PrintHello()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
    static void Main()
    {
        PrintHello();
    }
}

