namespace _01.School_Project
{
    class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
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
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                Validator.ValidateNumberOfLectures(value);
                this.numberOfLectures = value;
            }
        }
        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                Validator.ValidateNumberOfExercises(value);
                this.numberOfExercises = value;
            }
        }
        public void AddComment(string comment)
        {
            this.Comment = comment;
        }
    }
}

