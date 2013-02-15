using System;

class MathExpression
{
    static void Main()
    {

        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        double num = (n * n + (1.0 / (m * p)) + 1337.0);
        double den = (n - (128.523123123d * p));
        double result = ((num / den) + Math.Sin((int)m % 180));
        Console.WriteLine("{0:F6}", result);
    }
}

