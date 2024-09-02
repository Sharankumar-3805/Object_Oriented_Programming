using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Employee
    {
        private int[] Age = new int[5];

        //Making indexer 
        public int this[int index]
        {
            set {
                if (index >= 0 && index<Age.Length)
                {
                    if (value > 0)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Value is invalid!!");
                    }
                }
                else
                {
                    Console.WriteLine("please check array size");
                }
            }
            get {
               return Age[index];
            }
            
        }
    }
    internal class Indexer
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp[0] = 1;
            emp[1] = 2;
            emp[2] = 3;
            emp[3] = 4;
            emp[4] = 5;
            Console.WriteLine(emp[0]);
            Console.WriteLine(emp[1]);
            Console.WriteLine(emp[2]);
            Console.WriteLine(emp[3]);
            Console.WriteLine(emp[4]);
            Console.ReadLine();
        }
    }
}
