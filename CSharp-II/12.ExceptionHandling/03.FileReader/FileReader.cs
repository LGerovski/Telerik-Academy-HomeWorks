using System;
using System.IO;

class FileReader
{
    static void Main()
    {
        Console.WriteLine("This program reads and prints the content of a file\n" +
            "by given full path to this file from the user.");
        Console.Write("\nPlease enter the full path to the file you want to read: ");
        string fileContent = null;
        try
        {
            fileContent = File.ReadAllText(Console.ReadLine());
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
        catch (Exception)
        {
            Console.WriteLine("The operation was not successiful.");
            throw;
        }
        Console.WriteLine(fileContent);
    }
}

