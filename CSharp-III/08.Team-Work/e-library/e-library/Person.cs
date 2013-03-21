using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    public abstract class Person
    {
        //Fields
        private string firstName;
        private string lastName;

        //Constructor
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //Properties
        public string FirstName
        {
            get {
                return this.firstName;
            }
            set
            {
                if (firstName != null)
                {
                    this.firstName = value;
                }
                else
                {
                    //throw new ArgumentException("Please add first name");
                }
                
            }
        }

        public string LastName
        {
            get 
            {
                return this.lastName;
            }
            set 
            {
                if (lastName != null)
                {
                    this.lastName = value;
                }
                else
                {
                   // throw new ArgumentException("Please add last name");
                }
            }
        }
    }
}
