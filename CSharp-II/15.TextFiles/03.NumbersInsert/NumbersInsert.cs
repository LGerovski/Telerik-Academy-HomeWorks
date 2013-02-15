using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

class NumbersInsert
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
        fullPath = path + "\\" + file;
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
    static void WriteToFile(StreamReader reader, StreamWriter writer)
    {
        int lineNumber = 1;
        string line = reader.ReadLine();
        while (line != null)
        {
            writer.WriteLine("Line number {0}: {1}", lineNumber, line);
            line = reader.ReadLine();
            lineNumber++;
        }
    }
    static void Main()
    {
        Console.WriteLine("This program reads a text file and inserts line numbers in front\n" + 
            "of each of its lines. The result will be written to another text file.");
        StreamReader streamReader = GetFileReader(GetFullPath("", "read"));
        StreamWriter streamWriter = GetStreamWriter(GetFullPath("new", "write to"));
        WriteToFile(streamReader, streamWriter);
        streamReader.Close();
        streamWriter.Close();
        Console.WriteLine("The operation has been done.");
    }
}

