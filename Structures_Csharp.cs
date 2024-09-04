using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    struct Structures_Csharp
    {
        int i;
        public void Display()
        {
            Console.WriteLine("Methods in structures"+i);
        }
        static void Main()
        {
            Structures_Csharp sc;
            sc.i = 1;
            Console.WriteLine(sc.i);
            sc.Display();
            Console.ReadLine();
        }
    }
}
