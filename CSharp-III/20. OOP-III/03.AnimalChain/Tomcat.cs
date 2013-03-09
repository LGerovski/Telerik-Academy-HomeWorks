using System;

namespace _03.AnimalChain
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age, char gender) : base(name, age, gender) 
        {
            if (gender == 'F')
            {
                throw new ArgumentOutOfRangeException("Tomcats can only be male.");
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("Miaau");
        }
    }
}
