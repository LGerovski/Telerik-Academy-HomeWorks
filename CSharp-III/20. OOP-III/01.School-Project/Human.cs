namespace _01.School_Project
{
    class Human : IComment
    {
        protected string name;
        protected string comment;

        public Human(string name)
        {
            this.Name = name;            
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.ValidateName(value);
                this.name = value;
            }
        }
        public string Comment
        {
            get
            {
                return this.comment;
            }
            private set
            {
                Validator.ValidateComment(value);
                this.comment = value;
            }
        }
        public void AddComment(string comment)
        {
            this.Comment = comment;
        }
    }
}

