namespace _03.AnimalChain
{
    abstract class Animal : ISound
    {
        protected string name;
        protected int age;
        protected char gender;

        protected Animal(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        protected string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                this.age = value;
            }
        }
        protected char Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }
        public abstract void MakeSound();
        private string GetAnimalInfo()
        {
            return string.Format("Animal: {0,-10}| Name: {1,-15}| Age: {2,-2} years old   | Gender: {3}", this.GetType().Name, this.Name, this.Age, this.Gender);
        }
        public override string ToString()
        {
            if (this.Gender == 'M')
            {
                return GetAnimalInfo() + "ale";
            }
            else
            {
                return GetAnimalInfo() + "emale";
            }
        }
    }
}
