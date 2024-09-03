using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Null_reference_Exception
    {
        static void Main()
        {
            try
            {
                string name = null; // Set name to null
                Console.WriteLine(name.Length); // This will throw a NullReferenceException
            }
            catch (Exception ex)
            {
                Console.WriteLine("string is null"); // This will now be printed
            }
            Console.ReadLine();
        }
    }
}
