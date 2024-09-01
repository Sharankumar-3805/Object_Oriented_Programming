using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Person
    {
        private string Name;
        private int Age;

        public void setName(string Name)
        {
            if (string.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("Name is required");
            }
            else
            {
                this.Name = Name;
            }
        }
        public void getName()
        {
            if (string.IsNullOrEmpty(this.Name) == true)
            {

            }
            else
            {
                Console.WriteLine("Your name is : " + this.Name);
            }
        }
        public void setAge(int Age)
        {
            if (Age > 0)
            {
                this.Age = Age;
            }
            else
            {
                Console.WriteLine("Age should not be negative");
            }
        }
        public void getAge()
        {
           if(Age > 0)
            {
                Console.WriteLine("Your Age is:"+this.Age);
            }
            else
            {

            }
        }
    }
    internal class Encapsulation
    {
        static void Main()
        {
          Person p = new Person();
            p.setName("Sharan");
            p.setAge(10);
            p.getName();
            p.getAge();
            Console.ReadLine();
        }
    }
}
