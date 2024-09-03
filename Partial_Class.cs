using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Partial_Class
    {
        static void Main()
        {
            PartialClass_CSharp pc = new PartialClass_CSharp();
            Console.WriteLine("Enter first name:");
            pc.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            pc.LastName = Console.ReadLine();
            Console.WriteLine("Complete name:"+pc.getCompleteName());
            Console.ReadLine();
        }
    }
}
 