using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    class InvalidUserNameOrPassword : ApplicationException
    {
        public InvalidUserNameOrPassword() : base() { }
        public InvalidUserNameOrPassword(string message) : base(message) { }
        public InvalidUserNameOrPassword(string message, System.Exception inner) : base(message, inner) { }
    }
}
