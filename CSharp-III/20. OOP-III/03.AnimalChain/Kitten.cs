using System;

namespace _03.AnimalChain
{
    class Kitten : Cat
    {
        public Kitten(string name, int age, char gender) : base(name, age, gender) 
        {
            if (gender == 'M')
            {
                throw new ArgumentOutOfRangeException("Kittens can only be female.");
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meyur");
        }
    }
}
