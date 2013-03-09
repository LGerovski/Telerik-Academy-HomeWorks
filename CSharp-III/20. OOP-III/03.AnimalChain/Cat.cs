namespace _03.AnimalChain
{
    abstract class Cat : Animal
    {
        public Cat(string name, int age, char gender) : base(name, age, gender) { }
        public abstract override void MakeSound();
    }
}
