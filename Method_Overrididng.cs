using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Method_Overrididng
    {
        class parent
        {
            public virtual  void print()
            {
                Console.WriteLine("this is method of PARENT Class");
            }
        }

        class child : parent
        {
            public override void print()
            {
                Console.WriteLine("this is method of CHILD Class");
            }
        }
        static void Main()
        {
            parent p = new child();
            p.print();
            Console.ReadLine();
        }
    }
}
