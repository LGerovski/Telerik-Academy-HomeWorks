using System;
using System.Text;

class Matrix
{
    public int rows { get; set; }
    public int cols { get; set; }
    public int[,] matrix;

    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        matrix = new int[rows, cols];
    }
    public static Matrix operator +(Matrix matrixA, Matrix matrixB)
    {
        Matrix resultMatrix = new Matrix(matrixA.rows, matrixA.cols);
        for (int row = 0; row < matrixA.rows; row++)
        {
            for (int col = 0; col < matrixA.cols; col++)
            {
                resultMatrix.matrix[row, col] = matrixA.matrix[row, col] + matrixB.matrix[row, col];
            }
        }
        return resultMatrix;
    }
    public static Matrix operator -(Matrix matrixA, Matrix matrixB)
    {
        Matrix resultMatrix = new Matrix(matrixA.rows, matrixA.cols);
        for (int row = 0; row < matrixA.rows; row++)
        {
            for (int col = 0; col < matrixA.cols; col++)
            {
                resultMatrix.matrix[row, col] = matrixA.matrix[row, col] - matrixB.matrix[row, col];
            }
        }
        return resultMatrix;
    }
    public static Matrix operator *(Matrix matrixA, Matrix matrixB)
    {
        Matrix resultMatrix = new Matrix(matrixA.rows, matrixB.cols);
        for (int row = 0; row < matrixA.rows; row++)
        {
            for (int col = 0; col < matrixB.cols; col++)
            {
                for (int i = 0; i < matrixA.cols; i++)
                {
                    resultMatrix.matrix[row, col] += matrixA.matrix[row, i] * matrixB.matrix[i, col];
                }
            }
        }
        return resultMatrix;
    }
    public override string ToString()
    {
        StringBuilder matrixString = new StringBuilder();
        for (int row = 0; row < this.rows; row++)
        {
            for (int col = 0; col < this.cols; col++)
            {
                string currentValue = string.Format("{0,4}", this.matrix[row, col]);
                matrixString.Append(currentValue);
            }
            matrixString.AppendLine();
        }
        return matrixString.ToString();
    }
}
class OperatorsOverload
{
    static void Main()
    {
        Matrix matrixA = new Matrix(5, 5);
        Matrix matrixB = new Matrix(5, 5);
        for (int row = 0; row < matrixA.rows; row++)
        {
            for (int col = 0; col < matrixA.cols; col++)
            {
                matrixA.matrix[row, col] = row + col;
                matrixB.matrix[col, row] = row * col;
            }
        }
        Console.WriteLine("{0,15}", "MATRIX A");
        Console.WriteLine(matrixA);
        Console.WriteLine("{0,15}", "MATRIX B");
        Console.WriteLine(matrixB);
        Console.WriteLine("{0,18}", "MATRIX A + B");
        Console.WriteLine(matrixA + matrixB);
        Console.WriteLine("{0,18}", "MATRIX A - B");
        Console.WriteLine(matrixA - matrixB);
        Console.WriteLine("{0,18}", "MATRIX A * B");
        Console.WriteLine(matrixA * matrixB);
    }
}