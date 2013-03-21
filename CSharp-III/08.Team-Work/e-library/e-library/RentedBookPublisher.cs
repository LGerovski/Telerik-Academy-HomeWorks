using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    class RentedBookPublisher
    {
        public event EventHandler<RentedItemEvent> RaiseCustomEvent;
        public void RaiseEvent()
        {
            OnRaiseEvent(new RentedItemEvent(""));
        }
        protected virtual void OnRaiseEvent(RentedItemEvent e)
        {
            EventHandler<RentedItemEvent> handler = RaiseCustomEvent;
            if (handler != null)
            {
                e.Message += "Book rented";
                handler(this, e);
            }
            else
            {
                Console.WriteLine("There are no listeners.");
            }
        }
    }
}
