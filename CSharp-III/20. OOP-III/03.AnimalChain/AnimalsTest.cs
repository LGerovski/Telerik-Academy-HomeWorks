using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.AnimalChain
{
    class AnimalsTest
    {
        static void Main()
        {
            List<Animal> zoo = new List<Animal>();
            zoo.Add(new Dog("Bobi", 2, 'M'));
            zoo.Add(new Kitten("Megie", 1, 'F'));
            zoo.Add(new Frog("Gabie", 4, 'F'));
            zoo.Add(new Kitten("Apple", 3, 'F'));
            zoo.Add(new Kitten("Bibs", 5, 'F'));
            zoo.Add(new Kitten("Brandy", 8, 'F'));
            zoo.Add(new Tomcat("Tango", 1, 'M'));
            zoo.Add(new Tomcat("Fefe", 7, 'M'));
            zoo.Add(new Tomcat("Flash", 3, 'M'));
            zoo.Add(new Tomcat("Hank", 4, 'M'));
            zoo.Add(new Frog("Kalie", 1, 'F'));
            zoo.Add(new Frog("Buster", 12, 'M'));
            zoo.Add(new Frog("Dart", 4, 'M'));
            zoo.Add(new Dog("Cairo", 6, 'M'));
            zoo.Add(new Dog("Caleb", 11, 'M'));
            zoo.Add(new Dog("Captain", 1, 'M'));
            zoo.Add(new Dog("Chopper", 7, 'M'));
            foreach (Animal animal in zoo)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine();
            var animalGroups =
                from animal in zoo
                group animal by animal.GetType().Name into groups
                select new { groupName = groups.Key, animals = groups.ToList() };
            foreach (var group in animalGroups)
            {
                Console.WriteLine("Group: {0, 9}s | Average age: {1}", group.groupName.ToString(), GetAverageAge(group.animals));
            }
            Console.WriteLine();
        }
        private static double GetAverageAge(List<Animal> group)
        {
            int age = 0;
            int animals = 0;
            foreach (var animal in group)
            {
                age += animal.Age;
                animals++;
            }
            return (double)age / animals;
        }
    }
}
