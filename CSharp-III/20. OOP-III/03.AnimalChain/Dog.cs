using System;

namespace _03.AnimalChain
{
    class Dog : Animal
    {
        public Dog(string name, int age, char gender) : base(name, age, gender) { }
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
}
