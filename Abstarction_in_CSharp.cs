using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    abstract class Class1
    {
        public abstract void Add(int x, int y); //Abstarct Method only declared not defined
    }
    class class2 : Class1
    {
        public override void Add(int x ,int y)
        {
            Console.WriteLine("Implemented Abstract Method");
            int result = x + y;
            Console.WriteLine(result);
        }
    }
    internal class Abstarction_in_CSharp
    {
      
        static void Main()
        {
            class2 cl2 = new class2();
            cl2.Add(100, 200);
            Console.ReadLine();
        }
    }
}
