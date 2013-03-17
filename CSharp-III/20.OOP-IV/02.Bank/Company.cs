namespace _02.Bank
{
    class Company : Customer
    {
        public string BULSTAT { get; private set; }

        public Company(string name, string BULSTAT)
            : base(name)
        {
            Validator.ValidatePIN(BULSTAT, 9, "BULSTAT");
            this.BULSTAT = BULSTAT;
        }
    }
}
