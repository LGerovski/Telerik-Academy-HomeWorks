using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    public class LastingItem : LibraryItem
    {
        public LastingItem(string title)
            : base(title)
        {
        }

        public override void Rent()
        {
            throw new NotImplementedException();
        }
    }
}
