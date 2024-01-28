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
        
        static void Main(string[] args)
        {
            void functionxx(string s)
            {
                Console.WriteLine("The passed string is: " + s);
            }

            functionxx("ADEV-2008");

            Console.ReadKey();

        }    
    }
}
