using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    public delegate void Calculation(int num);
    internal class Multiple_Delegates
    {
        public static void Square(int num)
        {
            int square = num * num;
            Console.WriteLine("Square of "+ num +" is "+square);
        }
        public static void Cube(int num)
        {
            int square = num * num * num;
            Console.WriteLine("Cube of " + num + " is " + square);
        }
        static void Main()
        {
            Calculation c = new Calculation(Square);
            c.Invoke(5);
            c = Cube;
            c.Invoke(5);
            Console.ReadLine();
        }
    }
}
