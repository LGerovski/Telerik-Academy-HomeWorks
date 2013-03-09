class StudentsWithAge : Student
{
    public int Age { get; set; }

    public StudentsWithAge(string firstName, string lastName, int age)
        : base(firstName, lastName)
    {
        this.Age = age;
    }
}

