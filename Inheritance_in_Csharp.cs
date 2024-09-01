using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Inheritance_in_Csharp
    {
        class Temporary_Employees : Permanent_Employees //Multilevel Inheritance
        {
            public int TemporarySalary;
            public int TemporaryHours;
        }
        class Visiting_Employees : Employees //Heirarchical Inheritance 
        {
            public int visitingSalary;
            public int visitingHours;
        }
        class Permanent_Employees : Employees //Single Inheritance
        {
            public int permanentSalary;
            public int permanentHours;
        }
        class Employees
        {
            public int EmpId;
            public string EmpName;
            public string EmpAge;
            public int EmpContactNo;
         
        }
        static void Main(string[] args)
        {
            Permanent_Employees e1 = new Permanent_Employees();
            e1.EmpName = "sharan";
            Visiting_Employees v1 = new Visiting_Employees();
            v1.EmpName = "Hemangi";
            Employees e2 = new Employees();  
            Console.WriteLine(e1.EmpName);
            Console.WriteLine(v1.EmpName);
            Temporary_Employees t1 = new Temporary_Employees();
            t1.EmpContactNo = 9923758;
            Console.WriteLine(t1.EmpContactNo);
            Console.ReadLine();
        }
    }
}
