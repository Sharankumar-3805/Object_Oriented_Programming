using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Person1
    {
        public string Name;
        public int Age;

        public static Person1 operator +(Person1 p1 , Person1 p2)
        {
            Person1 p3 = new Person1();
            p3.Name = p1.Name +" "+ p2.Name;
            p3.Age = p1.Age+p2.Age;
            return p3;
        }
    }
    internal class Operator_Overloading_in_C_
    {
        static void Main()
        {
            Person1 p1 = new Person1();
            p1.Name = "A";
            p1.Age = 10;   

            Person1 p2 = new Person1();
            p2.Name = "B";
            p2.Age = 20;

            Person1 p3 = new Person1();
            p3 = p1 + p2;  
            Console.WriteLine(p3.Name);
            Console.WriteLine(p3.Age);
            Console.ReadLine();
        }
    }
}
