using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    enum Days1
    {
        Sunday,   //0
        Monday,   //1
        Tuesday,  //2
        Wednesday,//3
        Thursday, //4
        Friday,   //5
        Saturday, //6 
    }
    internal class EnumWithSwitch
    {
        static void Main()
        {
         Days1 md = Days1.Sunday;

            switch (md)
            {
                case Days1.Sunday:
                    Console.WriteLine("This is sunday");
                    break;
                case Days1.Monday:
                    Console.WriteLine("This is monday");
                    break;
                case Days1.Tuesday:
                    Console.WriteLine("This is tuesday");
                    break;
                case Days1.Wednesday:
                    Console.WriteLine("This is wednesday");
                    break;
                case Days1.Thursday:
                    Console.WriteLine("This is thursday");
                    break;
                case Days1.Friday:
                    Console.WriteLine("This is friday");
                    break;
                case Days1.Saturday:
                    Console.WriteLine("This is saturday");
                    break;
                     
                default:
                    Console.WriteLine("Invalid day...");
                    break;
                    
            }
            Console.ReadLine();
        }
    }
}
