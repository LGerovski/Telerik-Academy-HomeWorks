using System;
using System.Linq;

class StudentsTest
{
    private static StudentsWithAge[] GetStudents(StudentsWithAge[] studentsList)
    {
        var newList =
            from student in studentsList
            where student.Age >= 18 && student.Age <= 24
            select student;
        return newList.ToArray();
    }
    static void Main(string[] args)
    {
        StudentsWithAge[] studentsList = new StudentsWithAge[5];
        studentsList[0] = new StudentsWithAge("Stefan", "Petrov", 22);
        studentsList[1] = new StudentsWithAge("Todor", "Georgiev", 31);
        studentsList[2] = new StudentsWithAge("Angel", "Gospodinov", 15);
        studentsList[3] = new StudentsWithAge("Aleksander", "Dimitrov", 18);
        studentsList[4] = new StudentsWithAge("Peter", "Petrov", 24);
        Console.WriteLine("Original List\n");
        foreach (var student in studentsList)
        {
            Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
        }
        StudentsWithAge[] newList = GetStudents(studentsList);
        Console.WriteLine("\nNew List\n");
        foreach (var student in newList)
        {
            Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
        }
        Console.WriteLine();
    }
}

