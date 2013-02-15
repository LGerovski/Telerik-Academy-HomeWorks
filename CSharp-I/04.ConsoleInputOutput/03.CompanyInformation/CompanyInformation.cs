using System;

class CompanyInformation
{
    static void Main()
    {
        string companyName;
        string companyAddress;
        string companyPhoneNumber;
        string companyFaxNumber;
        string companyWebSite;
        string companyManager;
        string managerFirstName;
        string managerLastName;
        string managerAge;
        string managerPhoneNumber;
        Console.WriteLine("This program reads the information about a company \nand its manager and prints them on the console.");
        Console.Write("\nPlease enter company name: ");
        companyName = Console.ReadLine();
        Console.Write("Please enter company address: ");
        companyAddress = Console.ReadLine();
        Console.Write("Please enter company phone number: ");
        companyPhoneNumber = Console.ReadLine();
        Console.Write("Please enter company fax number: ");
        companyFaxNumber = Console.ReadLine();
        Console.Write("Please enter company web site: ");
        companyWebSite = Console.ReadLine();
        Console.Write("Please enter company manager: ");
        companyManager = Console.ReadLine();
        Console.Write("Please enter manager's first name: ");
        managerFirstName = Console.ReadLine();
        Console.Write("Please enter manager's last name: ");
        managerLastName = Console.ReadLine();
        Console.Write("Please enter manager's age: ");
        managerAge = Console.ReadLine();
        Console.Write("Please enter manager's phone number: ");
        managerPhoneNumber = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Company name: {0}", companyName);
        Console.WriteLine("Company address: {0}", companyAddress);
        Console.WriteLine("Company phone number: {0}", companyPhoneNumber);
        Console.WriteLine("Company fax number: {0}", companyFaxNumber);
        Console.WriteLine("Company web site: {0}", companyWebSite);
        Console.WriteLine("Company manager: {0}", companyManager);
        Console.WriteLine();
        Console.WriteLine("Manager's name: {0} {1} and age: {2}", managerFirstName, managerLastName, managerAge);
        Console.WriteLine("Manager's phone number: {0}", managerPhoneNumber);
        Console.WriteLine();
    }
}

