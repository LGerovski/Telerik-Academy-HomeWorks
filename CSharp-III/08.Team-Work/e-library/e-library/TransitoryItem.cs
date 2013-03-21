using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    class TransitoryItem : LibraryItem
    {

        public TransitoryItem(string title)
            : base(title)
        {
        }

        public override void Rent()
        {
            throw new NotImplementedException();
        }
    }
}
