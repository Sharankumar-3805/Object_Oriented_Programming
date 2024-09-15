using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    enum Days
    {
        Sunday,   //0
        Monday,   //1
        Tuesday,  //2
        Wednesday,//3
        Thursday, //4
        Friday,   //5
        Saturday, //6 
    }

    internal class EnumsInCSharp
    {   
        static void Main()
        {
            string[] members = Enum.GetNames(typeof(Days));
            foreach (string member in members)
            {
                Console.WriteLine(member);
            } 
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your day Sunday =1,Monday=2,Tuesday=3:");
            int value = int.Parse(Console.ReadLine());
            Days myDay = (Days)value;
            Console.WriteLine("My name is :" + name + " And my Birthday is:"+myDay);
            //int value = (int)Days.Saturday;
            //Console.WriteLine(value);
            //Console.WriteLine("User-Defined Enums");
            //Console.WriteLine(0); // 1st way calling
            ////Days bday = Days.Sunday;
            //Days myDay = (Days)1;
            //Console.WriteLine(myDay);
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Black;
            ////Console.WriteLine(bday);
            //Console.WriteLine("Built-in Enums");
            //Console.BackgroundColor = ConsoleColor.Magenta;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("My name is sharankumar");
            Console.ReadLine();
        }
    }
}
