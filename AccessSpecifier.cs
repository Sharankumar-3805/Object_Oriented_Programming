using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    public class class1
    {
        public void show1()
        {
            Console.WriteLine("this is public method");
        }
        public void show2()
        {
         class1 c1 = new class1();
            c1.show1();
        }
    }
    internal class AccessSpecifier : class1
    {
        static void Main()
        {
            
             class1 c1 = new class1();
                c1.show2();
                Console.ReadLine();
           
        }
    }
}
