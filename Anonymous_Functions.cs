using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    public delegate void myDelegate(int num);
    internal class Anonymous_Functions
    {
        //public static void MyMethod(int a)
        //{
        //    a = a + 10;
        //    Console.WriteLine(a);
        //}
        static void Main()
        {
            myDelegate md = delegate (int a)
            {
                a += 10;
                Console.WriteLine(a);
            };
            md.Invoke(10);
            md(10);
            Console.ReadLine();
        }
    }
}
