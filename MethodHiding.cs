using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class employee
    {
        public string firstName;
        public string lastName;
    public void printname()
        {
            Console.WriteLine("Parent class Method");
            Console.WriteLine(firstName+" "+lastName);
        }
    }
    class partTimeEmployee : employee
    {
        public new void printname()
        {
            base.printname();
            //Console.WriteLine("Part-time Employee");
            //Console.WriteLine("Parent class Method");
            //Console.WriteLine(firstName + " " + lastName+" PTE");
        }
    }
    class fullTimeEmployee : employee
    {
        public new void printname()
        {
            Console.WriteLine("Full-time Employee");
            Console.WriteLine("Parent class Method");
            Console.WriteLine(firstName + " " + lastName+" FTE");
        }
    }
    internal class MethodHiding
    {
        static void Main()
        {
            partTimeEmployee PTE = new partTimeEmployee();
            PTE.firstName = "Sharankumar";
            PTE.lastName = "Patil";
            PTE.printname();
            Console.ReadLine();
        }
    }
}
