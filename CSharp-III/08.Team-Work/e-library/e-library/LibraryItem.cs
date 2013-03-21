using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    public abstract class LibraryItem : IRentable
    {
        private string title;
        private string Rentee { get; set; }

        public LibraryItem(string title)
        {
            this.Title = title;
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Title must not be empty!");
                }
                else
                {
                    this.title = value;
                }
            }
        }

        public abstract void Rent();

        public void Rented(Book book)
        {
            this.Rentee = "Rentee";
        }
    }
}
