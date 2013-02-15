using System;
using System.Collections.Generic;
using System.IO;
using System.Security;

class SortingFile
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
    static string[] GetArray(StreamReader reader)
    {
        string line = null;
        List<string> arrayList = new List<string>();
        do
        {
            line = reader.ReadLine();
            if (line != null)
	        {
                arrayList.Add(line);
	        }
        } while (line != null);
        string[] array = arrayList.ToArray();
        return array;
    }
    static void PrintToFile(string[] array, StreamWriter writer)
    {
        foreach (var item in array)
        {
            writer.WriteLine(item);
        }
    }
    static void Main()
    {
        Console.WriteLine("This program reads a text file containing a list of strings,\n" + 
            "sorts them and saves them to another text file.");
        StreamReader streamReader = GetFileReader(GetFullPath("", "read"));
        StreamWriter streamWriter = GetStreamWriter(GetFullPath("new", "write to"));
        string[] array = GetArray(streamReader);
        Array.Sort(array);
        PrintToFile(array, streamWriter);
        streamReader.Close();
        streamWriter.Close();
        Console.WriteLine("The operation has been done.");
    }
}
