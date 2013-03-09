using System;

namespace _03.AnimalChain
{
    class Validator
    {
        public static void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("The name should not be empty.");
            }
            if (name.Length > 15)
            {
                throw new ArgumentOutOfRangeException("The name should not be longer than fifteen characters.");
            }
        }
        public static void ValidateAge(int age)
        {
            if (age < 0 || age > 200)
            {
                throw new ArgumentOutOfRangeException("the age cannot be negative or older than 200 years.");
            }
        }
        public static void ValidateGender(char gender)
        {
            if (gender != 'M' && gender != 'F')
            {
                throw new ArgumentOutOfRangeException("Gender can be only male or female.");
            }
        }
    }
}
