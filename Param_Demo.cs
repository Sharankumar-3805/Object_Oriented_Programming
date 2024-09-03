using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{  
  internal class Param_Demo
    {
        public static int add(params int[] nums)
        {
            int sum = 0;
           foreach (int i in nums)
            {
                sum += i;
            }
           return sum; 
        }
        static  void Main()
        {
            Console.WriteLine(Param_Demo.add(10,20,30,40));
            Console.ReadLine();
        }
    }
}
