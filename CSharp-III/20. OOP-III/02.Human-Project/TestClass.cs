using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Human_Project
{
    class TestClass
    {
        private static List<Student> GetStudents()
        {
            List<Student> studentsList = new List<Student>();
            studentsList.Add(new Student("Peter", "Petrov", 4.57));
            studentsList.Add(new Student("Stoyan", "Petrov", 3.22));
            studentsList.Add(new Student("Georgi", "Apostolov", 5.59));
            studentsList.Add(new Student("Neven", "Kostov", 5.97));
            studentsList.Add(new Student("Goran", "Angelov", 4.63));
            studentsList.Add(new Student("Daniel", "Hristov", 4.21));
            studentsList.Add(new Student("Plamen", "Georgiev", 5.59));
            studentsList.Add(new Student("Plamen", "Georgiev", 5.59));
            studentsList.Add(new Student("Plamen", "Aleksandrov", 3.97));
            studentsList.Add(new Student("Dobromir", "Kovachev", 4.90));
            return studentsList;

        }
        private static List<Worker> GetWorkers()
        {
            List<Worker> workersList = new List<Worker>();
            workersList.Add(new Worker("Vladimir", "Dimitrov", 880, 8));
            workersList.Add(new Worker("Angel", "Bogdanov", 1100.55m, 9));
            workersList.Add(new Worker("Alexander", "Kalinov", 1005.22m, 7.5));
            workersList.Add(new Worker("Peter", "Kremenov", 775.90m, 7.2));
            workersList.Add(new Worker("Tihomir", "Tihomirov", 580, 6));
            workersList.Add(new Worker("Daniel", "Traichev", 1389.40m, 9.2));
            workersList.Add(new Worker("Kalin", "Nedkov", 888.88m, 8));
            workersList.Add(new Worker("Zhivko", "Dobrinov", 1500, 10));
            workersList.Add(new Worker("Zvezdelin", "Marinov", 920.50m, 8));
            workersList.Add(new Worker("Lachezar", "Manolov", 447.23m, 3.5));
            return workersList;
        }
        static void Main()
        {
            List<Student> studentsList = GetStudents();
            List<Student> sortedStudents =
                (from student in studentsList
                orderby student.Grade
                select student).ToList();
            List<Worker> workersList = GetWorkers();
            List<Worker> sortedWorkers =
                (from worker in workersList
                 orderby worker.MoneyPerHour() descending
                 select worker).ToList();
            List<Human> allHumans = new List<Human>();
            foreach (var student in sortedStudents)
            {
                allHumans.Add(student);
            }
            foreach (var worker in sortedWorkers)
            {
                allHumans.Add(worker);
            }
            var sortedHumans =
                from human in allHumans
                orderby human.LastName
                orderby human.FirstName
                select human;
            foreach (var human in sortedHumans)
            {
                Console.WriteLine(human);
            }
        }

       
    }
}
