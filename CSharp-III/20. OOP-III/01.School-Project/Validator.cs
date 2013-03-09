using System;
using System.Collections.Generic;

namespace _01.School_Project
{
    class Validator
    {
        public static void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("The name should not be empty.");
            }
            if (name.Length > 50)
            {
                throw new ArgumentOutOfRangeException("The name should not be longer than fifty characters.");
            }
            foreach (var letter in name)
	        {
                if (!((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z') || letter == '-' || letter == ' '))
                {
                    throw new ArgumentException("Name can consist only latin letters and hyphens");
                }
	        }
        }
        private static void ValidateNumber(int number)
        {
            if (number < 0 || number > 100)
            {
                throw new IndexOutOfRangeException();
            }
        }
        public static void ValidateNumberOfLectures(int numberOfLectures)
        {
            ValidateNumber(numberOfLectures);
        }
        public static void ValidateNumberOfExercises(int numberOfExercises)
        {
            ValidateNumber(numberOfExercises);
        }
        public static void ValidateTeacher(Teacher teacher, Dictionary<Teacher, int> teachersList)
        {
            int value;
            if (teachersList.TryGetValue(teacher, out value))
            {
                throw new ArgumentException("This teacher has already been added to this class. Cannot add the same teacher again.");
            }
        }
        public static void ValidateDiscipline(Discipline discipline, Dictionary<Discipline, int> setOfDisciplines)
        {
            int value;
            if (setOfDisciplines.TryGetValue(discipline, out value))
            {
                throw new ArgumentException("This discipline has already been assigned to this teacher. Cannot add the same discipline again.");
            }
        }
        public static void ValidateComment(string comment)
        {
            if (string.IsNullOrEmpty(comment))
            {
                throw new ArgumentNullException("Comments should not be empty.");
            }
        }
    }
}
