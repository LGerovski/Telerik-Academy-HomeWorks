using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

class WordsOccurence
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
        Console.WriteLine("This program reads a list of words from a file words.txt\n" + 
            "and finds how many times each of the words is contained\n" + 
            "in another file test.txt.");
        Console.WriteLine("The result should be written in the file result.txt");
        StreamReader streamReader = GetFileReader("test.txt");
        StringBuilder fileContent = GetFileContent(streamReader);
        streamReader.Close();
        streamReader = GetFileReader("words.txt");
        string[] dictionary = GetDictionary(streamReader);
        streamReader.Close();
        string content = fileContent.ToString();
        Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();
        foreach (var item in dictionary)
        {
            string pattern = String.Format(@"\b{0}\b", item);
            wordsDictionary.Add(item, Regex.Matches(content, pattern).Count);
        }
        wordsDictionary = wordsDictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        StreamWriter streamWriter = GetStreamWriter("result.txt");
        fileContent.Clear();
        foreach (var item in wordsDictionary)
        {
            fileContent.AppendFormat("{0} - {1} occurrences.", item.Key, item.Value);
            fileContent.AppendLine();
        }
        streamWriter.WriteLine(fileContent);
        streamWriter.Close();
        Console.WriteLine("The operation has been done.");
    }
}

