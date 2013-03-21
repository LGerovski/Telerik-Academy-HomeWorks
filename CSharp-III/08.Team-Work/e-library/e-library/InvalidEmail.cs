using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    class InvalidEmail : ApplicationException
    {
        public InvalidEmail() : base() { }
        public InvalidEmail(string message) : base(message) { }
        public InvalidEmail(string message, System.Exception inner) : base(message, inner) { }
    }
}
