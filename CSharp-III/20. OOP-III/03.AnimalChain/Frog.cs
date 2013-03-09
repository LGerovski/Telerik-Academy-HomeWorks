using System;

namespace _03.AnimalChain
{
    class Frog : Animal
    {
        public Frog(string name, int age, char gender) : base(name, age, gender) { }
        public override void MakeSound()
        {
            Console.WriteLine("Croak");
        }
    }
}
