using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Format_Exception_CSharp
    {
        static void Main()
        {
            Console.WriteLine("Enter Number:-");
            string number = Console.ReadLine();
            try
            {
                int num = int.Parse(number);
                Console.WriteLine("Number is :" + num);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Enter proper format");
            }
            Console.ReadLine();
        }
    }
}
