using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Throw_Throws
    {
        static void Main()
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            try
            {
                if (age >= 18)
                {
                    Console.WriteLine("You can vote");
                }
                else
                {
                    throw new Exception("You Cannot vote");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
             Console.ReadLine();
        }
    }
}
