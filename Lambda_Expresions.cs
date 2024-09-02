using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    public delegate int MyDelegate(int num);
    internal class Lambda_Expresions
    {
        static void Main()
        {
            //We dont have to mention datatype of value
            //MyDelegate md1 = (a) =>  //Statement lambda
            //{
            //    a += 5;
            //    Console.WriteLine(a);
            //};
            MyDelegate md3 = (a) => a * a; // Expression Lambda
            MyDelegate md2 = (a) => a * a * a; // Expression Lambda
            Console.WriteLine(md3.Invoke(5));
            Console.WriteLine(md2.Invoke(5));
            //Console.WriteLine(md1.Invoke(5));
            //md1.Invoke(5);
            Console.ReadLine();
        }
    }
}
