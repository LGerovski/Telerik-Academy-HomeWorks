using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    public class RentedItemEvent : EventArgs
    {
        public string Message { get; set; }
        public RentedItemEvent(string message)
        {
            this.Message = message;
        }

    }
}
