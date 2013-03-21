using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    public class Administrator : User
    {
        //Constructor
        public Administrator(string firstName, string lastName, string email, string password) 
            : this(firstName, lastName, email, password, null) { }
        public Administrator(string firstName, string lastName, string email, string password, string address)
            : this(firstName, lastName, email, password, address, null) { }
        public Administrator(string firstName, string lastName, string email, string password, string address, string phoneNumber)
            : base(firstName, lastName, email, password, address, phoneNumber) { }


        public void AddAuthorstoList(Author author)
        {
            Library.authorsList.Add(author);
        }
        public void AddBookstoLibrary(Book book)
        {
            Library.booksList.Add(book);
        }
        public override void Interact()
        {
            AdminForm newAdmin = new AdminForm(this);
            newAdmin.Show();
        }
    }
}
