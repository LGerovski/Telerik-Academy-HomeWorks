using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    public class Book : PaperMedia
    {
        //Fields
        private Author bookAuthor;
        private Language bookLanguage;
        public BookSection bookSection;

        //Constructor
        public Book(string title, Author author, Language language, BookSection bookSection)
            : base(title)
        {
            this.BookAuthor = author;
            this.BookLanguage = language;
            this.bookSection = bookSection;
        }

        //Property
        public Author BookAuthor
        {
            get
            {
                return this.bookAuthor;
            }
            set
            {
                this.bookAuthor = value;
            }
        }
        public Language BookLanguage
        {
            get
            {
                return this.bookLanguage;
            }
            set
            {
                this.bookLanguage = value;
            }
        }
        public override string ToString()
        {
            return base.Title;
        }
    }
}
