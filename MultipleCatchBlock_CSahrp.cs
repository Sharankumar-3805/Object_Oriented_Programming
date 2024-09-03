using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class MultipleCatchBlock_CSahrp
    {
        static void Main()
        {
            try
            {
                int a = 10;
                int b = 0 ;
                int c = a / b;
                Console.WriteLine(c);
                string a2 = Console.ReadLine();
                int n = int.Parse(a2);
                Console.WriteLine(n);
                int[] a1 = new int[4];
                a1[0] = 1;
                a1[1] = 1;
                a1[2] = 1;
                a1[3] = 1;
                Console.WriteLine(a1[1]);
            }
            catch (DivideByZeroException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (NullReferenceException e2)
            {
                Console.WriteLine(e2.Message);
            }
            catch (IndexOutOfRangeException e3)
            {
                Console.WriteLine(e3.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed implicitly");
            }
          Console.ReadLine();
        }
    }
}
