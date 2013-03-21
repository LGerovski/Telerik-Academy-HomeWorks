using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library
{
    class DigitalMedia : LastingItem
    {
        public string Publisher { get; set; }

        public DigitalMedia(string title, string publisher)
            : base(title)
        {
            this.Publisher = publisher;
        }
    }
}
