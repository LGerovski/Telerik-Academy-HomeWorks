namespace _02.Bank
{
    class Individual : Customer
    {
        public string PIN { get; private set; }

        public Individual(string name, string PIN)
            : base(name)
        {
            Validator.ValidatePIN(PIN, 10, "PIN");
            this.PIN = PIN;
        }
    }
}
