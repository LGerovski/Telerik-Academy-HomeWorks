using System;

namespace _02.Bank
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
        public static void ValidatePIN(string PIN, int length, string type)
        {
            if (PIN.Length != length)
            {
                throw new ArgumentException("The {0} number should be ten digits.", type);
            }
            foreach (var digit in PIN)
            {
                if (digit < '0' || digit > '9')
                {
                    throw new ArgumentException("The {0} number can contain only digits.",  type);
                }
            }
        }
    }
}
