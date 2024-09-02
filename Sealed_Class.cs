using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
     class Wood
    {
        public virtual void price()
        {
            Console.WriteLine("price is 3500");
        }
    }
    class table : Wood
    {
        public override void price()
        {
            Console.WriteLine("price is 5500");
        }
    }
    class chair : table
    {
        public override void price()
        {
            Console.WriteLine("price is 8500");
        }
    }
    internal class Sealed_Class
    {
        static void Main()
        {
chair c = new chair();
            Console.ReadLine();
        }
    }
}
