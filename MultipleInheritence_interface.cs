using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    interface interface1
    {
        void test();
    }
    interface interface2
    {
        void test();
    }
    internal class MultipleInheritence_interface : interface1, interface2
    {
        public void test()
        {
            Console.WriteLine("Interface method implemented in child class");
        }
        static void Main()
        {
            MultipleInheritence_interface mii = new MultipleInheritence_interface();
            mii.test();
            
         Console.ReadLine();
        }
    }
}
