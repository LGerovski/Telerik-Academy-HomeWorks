using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    public abstract class User : Person, IInteractable
    {
        //Fields
        private string email;
        private string password;
        private string address;
        private string phone;
        public List<Book> rentedBooks;

        //Constructor
        public User(string firstName, string lastName, string email, string password, string address, string phone)
            : base (firstName, lastName)
        {
            this.Email = email;
            this.Password = password;
            this.Address = address;
            this.Phone = phone;
            rentedBooks = new List<Book>();
        }

        //Properties
        public string Email 
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value.Length >= 5)
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Please enter email");
                }
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                // needs validation
                this.password = value;
            }
        }
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
               // if (value.Length >= 5 || value == null)
                {
                    this.address = value;
                }
               // else
                {
                    //throw new ArgumentException("Please enter address");
                }
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
               // if (value.Length >= 5 || value == null)
                {
                    this.phone = value;
                }
               // else
                {
                   // throw new ArgumentException("Please enter phone number");
                }
            }
        }

        public virtual void Interact()
        {
            ClientForm newClient = new ClientForm(this);
            newClient.Show();
        }
    }
}
