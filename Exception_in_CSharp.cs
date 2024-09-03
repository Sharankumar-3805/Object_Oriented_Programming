using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Exception_in_CSharp
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter 1st Number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number");
                int num2 = int.Parse(Console.ReadLine());
                int div = num1 / num2;
                Console.WriteLine("Division result is:" + div);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("You cannot divide by zero");
            }
            
            Console.WriteLine("Statement1 after exception ");
            Console.WriteLine("Statement2 after exception ");
            Console.WriteLine("Statement3 after exception ");
            Console.ReadLine();
        }
    }
}
