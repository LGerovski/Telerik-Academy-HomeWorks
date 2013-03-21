namespace e_library
{
    public class BookSection
    {
        //Fields
        private Section section;
        private int location;

        public BookSection(Section section)
        {
            this.Section = section;
            this.Location = (int)section;
        }

        //Properties
        public Section Section
        {
            get
            {
                return this.section;
            }
            set
            {
                this.section = value;
            }
        }

        public int Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }
    }
}
