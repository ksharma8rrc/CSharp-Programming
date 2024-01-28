using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Prog_1
{
    internal class Program
    {
        public class Adev
        {
            int a;
            string b;

            public void GetData(int xx, string yy)
            {
                this.a = xx;
                this.b = yy;
            }

            public void PrintData()
            {
                Console.WriteLine("This is the int I got: " + a);
                Console.WriteLine("this is the string i got: " +  b);
            }

        }

        static void Main(string[] args)
        {
            Adev obj1 = new Adev();
            obj1.GetData(5, "adev-2008");
            obj1.PrintData();

            Adev obj2 = new Adev();
            obj1.GetData(20, "Riley");
            obj1.PrintData();
            Console.ReadKey();

        }    
    }
}

