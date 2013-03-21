using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_library
{
    class RentedBookSubscriber
    {
        public RentedBookSubscriber(RentedBookPublisher myPublisher)
        {
            myPublisher.RaiseCustomEvent += HandleEvent;
        }
        void HandleEvent(object sender, RentedItemEvent e)
        {
            MessageBox.Show("Book has been rented");
        }
    }
}
