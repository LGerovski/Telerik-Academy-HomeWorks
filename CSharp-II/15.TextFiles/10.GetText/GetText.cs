using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

class GetText
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
    private static void GetFileContent(StreamReader reader)
    {
        string line = null;
        Regex pattern = new Regex("<.*?>");
        do
        {
            line = reader.ReadLine();
            if (line != null)
            {
                string result = pattern.Replace(line, "");
                if (result != "")
                {
                    Console.WriteLine(result);
                }
            }
        } while (line != null);
    }
    static void Main()
    {
        Console.WriteLine("This program extracts from given XML file all the text without the tags.");
        string path = GetFullPath("", "read");
        StreamReader streamReader = GetFileReader(path);
        GetFileContent(streamReader);
        streamReader.Close();
    }
}

