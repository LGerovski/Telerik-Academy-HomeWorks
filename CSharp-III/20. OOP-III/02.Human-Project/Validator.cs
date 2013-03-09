using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Human_Project
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
        public static void ValidateGrade(double grade)
        {
            if (grade < 2 || grade > 6)
            {
                throw new ArgumentOutOfRangeException("Grade must be between 2 and 6.");
            }
        }
        public static void ValidateSalary(decimal salary)
        {
            if (salary < 0)
            {
                throw new ArgumentOutOfRangeException("Salary cannot be negative");
            }
        }
        public static void ValidateWorkHours(double hours)
        {
            if (hours < 0 || hours > 24)
            {
                throw new ArgumentOutOfRangeException("Working hours cannot be negative and must be less than 24 per day.");
            }                           
        }
    }
}
