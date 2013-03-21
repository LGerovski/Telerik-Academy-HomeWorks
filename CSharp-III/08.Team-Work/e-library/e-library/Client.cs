using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    public class Client : User
    {
        //Fields
        public int ClientNumber { get; private set; }
        public static int NumberOfClients { get; private set; }
        


        //Constructor
        public Client(string firstName, string lastName, string email, string password)
            : this(firstName, lastName, email, password, null) { }
        public Client(string firstName, string lastName, string email, string password, string address)
            : this(firstName, lastName, email, password, address, null) { }
        public Client(string firstName, string lastName, string email, string password, string address, string phoneNumber)
            : base(firstName, lastName, email, password, address, phoneNumber) 
        {
            Client.NumberOfClients++;
            this.ClientNumber = Client.NumberOfClients;
            this.rentedBooks = new List<Book>();
        }
        public void Rent(Book book)
        {
            RentBook(book);
        }
        public void RentBook(Book book)
        {
            this.rentedBooks.Add(book);
        }
        public void ReturnBook(Book book)
        {
            this.rentedBooks.Remove(book);
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
        
    }
}
