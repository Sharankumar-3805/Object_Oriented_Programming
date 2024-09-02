using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{         //Defining a delegates
    public delegate void AddDelegates(int x, int y);
    public delegate string SayDelegates(string s); 
    class people
    {
        public void Addnums(int a,int b) //Called by instance of class
        {
            int total = a + b;
            Console.WriteLine("Total count is:"+total);
        }
        public static string community(String caste) //Called using program name itself because of static keyword
        {
            return "Cast name is:" + caste;
        }
    }
    internal class Delegates_in_CSharp
    {
        static void Main()
        {
            people pp = new people();
            AddDelegates ad = new AddDelegates(pp.Addnums);
            ad.Invoke(500, 500);
            pp.Addnums(1,2);

            SayDelegates sd = new SayDelegates(people.community);
           string str =  sd("Hindu");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
