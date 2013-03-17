using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.IdentifierTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple redApple = new Apple("Red");
            Console.WriteLine(redApple.GetColor());
        }
    }
}
