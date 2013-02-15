using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text;

class RemoveWords
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
    private static StringBuilder GetFileContent(StreamReader reader)
    {
        StringBuilder fileContent = new StringBuilder();
        string line = null;
        do
        {
            line = reader.ReadLine();
            if (line != null)
            {
                fileContent.Append(line);
                fileContent.AppendLine();
            }
        } while (line != null);
        return fileContent;
    }
    private static string[] GetDictionary(StreamReader reader)
    {
        List<string> dictionary = new List<string>();
        string word = null;
        do
        {
            word = reader.ReadLine();
            if (word != null)
            {
                dictionary.Add(word);
            }
        } while (word != null);
        string[] result = dictionary.ToArray();
        return result;
    }
    static void Main()
    {
        Console.WriteLine("This program removes from a text file all words listed in given another text file.");
        string path = GetFullPath("", "read");
        StreamReader streamReader = GetFileReader(path);
        StringBuilder fileContent = GetFileContent(streamReader);
        streamReader.Close();
        string dictionaryPath = GetFullPath("", "read the words from");
        streamReader = GetFileReader(dictionaryPath);
        string[] dictionary = GetDictionary(streamReader);
        streamReader.Close();
        foreach (var item in dictionary)
        {
            fileContent.Replace(item, "");
        }
        StreamWriter streamWriter = GetStreamWriter(path);
        streamWriter.WriteLine(fileContent);
        streamWriter.Close();
        Console.WriteLine("The operation has been done.");
    }
}

