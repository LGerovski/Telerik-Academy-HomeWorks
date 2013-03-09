using System;
using System.Linq;

class StudentsSort
{
    private static Student[] GetStudents(Student[] studentsList)
    {
        var newList =
            from student in studentsList
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;
        return newList.ToArray();
    }
    static void Main(string[] args)
    {
        Student[] studentsList = new Student[5];
        studentsList[0] = new Student("Stefan", "Petrov");
        studentsList[1] = new Student("Todor", "Georgiev");
        studentsList[2] = new Student("Angel", "Gospodinov");
        studentsList[3] = new Student("Aleksander", "Dimitrov");
        studentsList[4] = new Student("Peter", "Petrov");
        Console.WriteLine("Original List\n");
        foreach (var student in studentsList)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
        Student[] newList = GetStudents(studentsList);
        Console.WriteLine("\nNew List\n");
        foreach (var student in newList)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
        Console.WriteLine();
    }
}

