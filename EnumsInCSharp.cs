using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    enum Days
    {
        Sunday, //0
        Monday, //1
        Tuesday,//2
        Wednesday,//3
        Thursday,//4
        Friday,//5
        Saturday,//6
    }

    internal class EnumsInCSharp
    {   
        static void Main()
        {
            Console.WriteLine("User-Defined Enums");
            Console.WriteLine(Days.Monday); // 1st way calling
            Days bday = Days.Sunday;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(bday);
            Console.WriteLine("Built-in Enums");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("My name is sharankumar");
            Console.ReadLine();
        }
    }
}
