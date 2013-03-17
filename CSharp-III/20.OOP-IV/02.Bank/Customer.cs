namespace _02.Bank
{
    class Customer
    {
        protected string name { get; set; }

        protected Customer(string name)
        {
            Validator.ValidateName(name);
            this.name = name;
        }
    }
}
