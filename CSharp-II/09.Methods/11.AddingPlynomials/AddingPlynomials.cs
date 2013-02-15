using System;

class AddingPlynomials
{
    private static int GetPolynomialSize(string p)
    {
        if (p == "first")
        {
            return 3;
        }
        if (p == "second")
        {
            return 3;
        }
        return 0;
    }
    static int[] GetPolynomialElements(int n, string p)
    {
        int[] array = new int[n];
        if (p == "first")
        {
            array[0] = -11;
            array[1] = 0;
            array[2] = 5;
        }
        if (p == "second")
        {
            array[0] = 3;
            array[1] = -7;
            array[2] = 12;
        }
        return array;
    }
    static int[] SumPolynomials(int[] polyA, int[] polyB)
    {
        int[] polyC = new int[Math.Max(polyA.Length, polyB.Length)];
        for (int i = polyC.Length - 1; i >= 0; i--)
        {
            if (i < polyA.Length && i < polyB.Length)
            {
                polyC[i] = polyA[i] + polyB[i];
            }
            else if (i < polyA.Length)
            {
                polyC[i] = polyA[i];
            }
            else
            {
                polyC[i] = polyB[i];
            }
        }
        return polyC;
    }
    static void PrintSign(int number)
    {
        if (number < 0)
        {
            Console.Write(" - ");
        }
        else
        {
            Console.Write(" + ");
        }
    }
    static void PrintResultPolynomial(int[] polyC)
    {
        for (int i = 0; i < polyC.Length; i++)
        {
            if (polyC[i] != 0)
            {
                if (i > 0 || polyC[i] < 0)
                {
                    PrintSign(polyC[i]);
                }
                Console.Write(Math.Abs(polyC[i]));
                if (i < polyC.Length - 1)
                {
                    Console.Write("x");
                    if (i < polyC.Length - 2)
                    {
                        Console.Write(polyC.Length - i - 1);
                    }
                }
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("This program adds two polynomials.");
        Console.WriteLine("Polynomial A = - 11x2 + 5");
        Console.WriteLine("Polynomial B = 3x2 - 7x + 12");
        int n = GetPolynomialSize("first");
        int[] polyA = new int[n];
        polyA = GetPolynomialElements(n, "first");
        int m = GetPolynomialSize("second");
        int[] polyB = new int[m];
        polyB = GetPolynomialElements(m, "second");
        Console.Write("Polynomial A + B = ");
        int[] polyC = SumPolynomials(polyA, polyB);
        PrintResultPolynomial(polyC);
        Console.WriteLine();
    }
}

