using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    public delegate void calculations(int num1 , int num2);
    internal class Multicast_Delegates
    {
        public static void Add(int num1 , int num2)
        {
            int res = num1 + num2;
            Console.WriteLine("Addition is :"+res);
        }
        public static void Sub(int num1 , int num2)
        {
            int res = num1 - num2;
            Console.WriteLine("Substraction is :"+res);
        }
        public static void Mult(int num1 , int num2)
        {
            int res = num1 * num2;
            Console.WriteLine("Multiplication is :"+res);
        }
        public static void Div(int num1 , int num2)
        {
            int res = num1 / num2;
            Console.WriteLine("Division is :"+res);
        }
        public static void Mod(int num1 , int num2)
        {
            int res = num1 % num2;
            Console.WriteLine("Modulus is :"+res);
        }
        static void Main()
        {
            calculations c = new calculations(Add);
            c += Sub;
            c += Div;
            c += Mult;
            c += Mod;
            c(10,20);
            Console.ReadLine();
        }
    }
}
