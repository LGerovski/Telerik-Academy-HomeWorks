using System;

class SpiralMatrix
{
    static int n; //"n" is "matrixSize - 1" for easy calculations.
    static int[,] intArray;
    static int counter = 0;
    public static void FillMatrix(int c)
    {
        if (c >= n / 2 + 1)
        {
            return;
        }
        for (int i = c; i < n - c; i++) intArray[c, i] = GetCurrentCount();
        for (int i = c; i < n - c; i++) intArray[i, n - c] = GetCurrentCount();
        for (int i = c; i < n - c; i++) intArray[n - c, n - i] = GetCurrentCount();
        for (int i = c; i < n - c; i++) intArray[n - i, c] = GetCurrentCount();
        FillMatrix(c + 1);
    }
    public static int GetCurrentCount()
    {
        counter++;
        return counter;
    }
    public static void PrintMatrix()
    {
        for (int row = 0; row <= n; row++)
        {
            for (int col = 0; col <= n; col++)
            {
                Console.Write("{0,3} ", intArray[row, col]);
            }
            Console.WriteLine();
        }
    }
    public static void SetArray(int matrixSize)
    {
        n = matrixSize - 1;
        intArray = new int[matrixSize, matrixSize];
    }
    public static byte GetMatrixSize()
    {
        Console.Write("Please input \"n\" size of a spiral matrix, valid interval is: [0..19]: ");
        byte matrixSize = 0;
        if ((byte.TryParse(Console.ReadLine(), out matrixSize)) && matrixSize < 20)
        {
            Console.WriteLine();
            return matrixSize;
        }
        else
	    {
            Console.WriteLine("\nWrong input.\n");
            return 0;
	    }
    }
    static void Main()
    {
        byte matrixSize = GetMatrixSize();
        SetArray(matrixSize);
        FillMatrix(0);
        if (matrixSize % 2 != 0)
        {
            intArray[matrixSize / 2, matrixSize / 2] = Convert.ToInt32(Math.Pow(matrixSize, 2));
        }
        PrintMatrix();
        Console.WriteLine();
    }
}

