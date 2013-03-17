using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.IdentifierTest
{
    class Apple
    {
        private string color;

        public Apple(string color)
        {
            this.color = color;
        }
        private string Color
        {
            get
            {
                return this.color;
            }
        }
        public string GetColor()
        {
            return this.color;
        }
    }
}
