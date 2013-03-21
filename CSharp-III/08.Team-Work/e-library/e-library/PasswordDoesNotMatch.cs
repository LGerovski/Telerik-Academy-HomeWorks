using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    class PasswordDoesNotMatch : ApplicationException
    {
        public PasswordDoesNotMatch() : base() { }
        public PasswordDoesNotMatch(string message) : base(message) { }
        public PasswordDoesNotMatch(string message, System.Exception inner) : base(message, inner) { }
    }
}
