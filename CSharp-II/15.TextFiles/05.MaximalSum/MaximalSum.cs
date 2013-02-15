using System;
using System.IO;
using System.Security;

class MaximalSum
{
    static string GetFullPath(string fileNumber, string access)
    {
        string fullPath = null;
        string path = null;
        string file = null;
        Console.Write("\nPlease enter the full path to the {0} file you want to {1}: ", fileNumber, access);
        path = Console.ReadLine();
        Console.Write("Please enter file name: ");
        file = Console.ReadLine();
        if (path == "")
        {
            fullPath = file;
        }
        else
        {
            fullPath = path + "\\" + file;
        }
        return fullPath;
    }
    static StreamReader GetFileReader(string fullPath)
    {
        StreamReader reader = null;
        try
        {
            reader = new StreamReader(fullPath);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The path can not be null.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid path.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path is too long.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path could not be found.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The path is wrong or there is no such file.");
        }
        catch (IOException)
        {
            Console.WriteLine("The specified file could not be open.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("the program has no authorization to read this file.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The input format of the path is not supported by this program.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("Unsufficient permissoins");
        }
        catch (Exception)
        {
            Console.WriteLine("The operation was not successiful.");
            throw;
        }
        return reader;
    }
    static StreamWriter GetStreamWriter(string fullPath)
    {
        StreamWriter writer = null;
        try
        {
            writer = new StreamWriter(fullPath);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory information specified in path was not found.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path is too long.");
        }
        catch (IOException)
        {
            Console.WriteLine("The path is in an invalid format or contains invalid characters.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access to path is denied.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The path can not be null.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Empty path.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("Unsufficient permissoins");
        }
        catch (Exception)
        {
            Console.WriteLine("The operation was not successiful.");
            throw;
        }
        return writer;
    }
    static int[,] GetMatrix(StreamReader reader)
    {
        int n = int.Parse(reader.ReadLine());
        int[,] matrix = new int[n, n];
        for (int row = 0; row < n; row++)
        {
            string[] line = reader.ReadLine().Split();
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = int.Parse(line[col]);
            }

        }
        return matrix;
    }
    private static int GetMaxSumMatrix(int[,] matrix, int rows, int cols)
    {
        int maxSum = int.MinValue;
        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                int currentSum = matrix[row, col];
                currentSum += matrix[row, col + 1];
                currentSum += matrix[row + 1, col];
                currentSum += matrix[row + 1, col + 1];
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        return maxSum;
    }
    static void Main()
    {
        Console.WriteLine("This program reads a text file containing a square matrix of numbers\n" + 
            "and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.");
        Console.WriteLine("The output will be a single number in a separate text file.");
        StreamReader streamReader = GetFileReader(GetFullPath("", "read"));
        StreamWriter streamWriter = GetStreamWriter(GetFullPath("new", "write to"));
        int[,] matrix = GetMatrix(streamReader);
        int maxSum = GetMaxSumMatrix(matrix, matrix.GetLength(0), matrix.GetLength(1));
        streamWriter.WriteLine(maxSum);
        streamReader.Close();
        streamWriter.Close();
        Console.WriteLine("The operation has been done.");
    }
}
