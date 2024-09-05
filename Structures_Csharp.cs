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
        public Structures_Csharp(int i)
        {
            this.i = i;
            Console.WriteLine(i);
        }
        
        public void Display()
        {
            Console.WriteLine("Methods in structures"+i);
        }
        static void Main()
        {
            Structures_Csharp sc = new Structures_Csharp(20);
            sc.i = 10;   
            sc.Display();
            Console.ReadLine();
        }
    }
}
