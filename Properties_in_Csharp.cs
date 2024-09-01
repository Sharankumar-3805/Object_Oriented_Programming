using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Student
    {
        private int _StdId;
        private string _Name;
        private string _Fname;
        private int _STMarks = 500;
        public string MiddleName { get; private set; }  // Auto-Implemented properties the combination of private variables and getters and setters
        
        public Student(string Mname)
        {
            
            MiddleName = Mname;
        }
        public int StdId
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Id cannot be zero");
                }
                else
                {
                    this._StdId = value;
                }
            }
            get
            {
                return this._StdId;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value) == true)
                {
                    Console.WriteLine("Please enter your name:");
                }
                else
                {
                    this._Name = value;
                }
            }
            get
            {
                return this._Name;
            }
        }
        public string FName
        {
            set
            {
                if (string.IsNullOrEmpty(value) == true)
                {
                    Console.WriteLine("Please enter your name:");
                }
                else
                {
                    this._Fname = value;
                }
            }
            get
            {
                return this._Fname;
            }
        }
        public int STMarks
        {
            get
            {
                return this._STMarks;
            }
        }
    }

        internal class Properties_in_Csharp
        {
            static void Main() {
                Student s = new Student("Sharan");
                Console.WriteLine("Enter Student ID:");
                s.StdId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Name:");
                s.Name = Console.ReadLine();
                Console.WriteLine("Enter Student FName:");
                s.FName = Console.ReadLine();
                Console.WriteLine("Student details:");
                Console.WriteLine("Student ID :"+s.StdId);
                Console.WriteLine("Student Name :"+s.Name);
                Console.WriteLine("Student Father Name:" + s.FName);
                 Console.WriteLine("Marks obtained by student:"+s.STMarks);
            Console.WriteLine("Lastname of student"+s.MiddleName);
                Console.ReadLine();
            }
        }
    } 
