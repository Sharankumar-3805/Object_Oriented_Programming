using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Index_Out_of_Range_Exception
    {
        static void Main()
        {
            int[] a = new int[3];
            try
            {
                a[0] = 1;
                a[1] = 2;
                a[2] = 3;
                a[3] = 4;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
