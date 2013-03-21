using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    class FailedLoginExeption : ApplicationException
    {
        //Fields
        private string username;

        //Properties
        public string Username
        {
            get
            {
                return this.username;
            }
        }

        //Constructor
        public FailedLoginExeption(string msg)
            : base(msg)
        {
        }

        public FailedLoginExeption(string msg, string username)
            : base(msg)
        {
            this.username = username;
        }
    }
}
