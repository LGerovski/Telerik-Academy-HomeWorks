using System;
using System.IO;
using System.Security;

class OddLines
{
    static string GetFullPath()
    {
        string fullPath = null;
        string path = null;
        string file = null;
        Console.Write("\nPlease enter the full path to the file you want to read: ");
        path = Console.ReadLine();
        Console.Write("Please enter file name: ");
        file = Console.ReadLine();
        fullPath = path + "\\" + file;
        return fullPath;
    }
    static StreamReader GetFileReader()
    {
        StreamReader reader = null;
        try
        {
            reader = new StreamReader(GetFullPath());
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
    static void Main()
    {
        Console.WriteLine("This program reads a text file and prints on the console its odd lines.");
        StreamReader reader = GetFileReader();
        using (reader)
        {
            int lineNumber = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 == 1)
                {
                    Console.WriteLine("{0}", line);
                }
                line = reader.ReadLine();
                lineNumber++;
            }
        }
    }
}

