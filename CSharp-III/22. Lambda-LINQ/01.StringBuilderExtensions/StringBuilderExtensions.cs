using System;
using System.Text;

class StringBuilderExtensions
{
    static void Main(string[] args)
    {
        StringBuilder newBuilder = new StringBuilder();
        newBuilder.Append("Hello World!");
        Console.WriteLine(newBuilder);
        newBuilder = newBuilder.Substring(2, 8);
        Console.WriteLine(newBuilder);
    }
}

public static class ExtendStringBuilder
{
    public static StringBuilder Substring(this StringBuilder builder, int index, int length)
    {
        StringBuilder newBuilder = new StringBuilder();
        for (int i = index; i < index + length; i++)
        {
            newBuilder.Append(builder[i]);
        }
        return newBuilder;
    }
}