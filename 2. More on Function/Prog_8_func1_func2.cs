// Prog_5,6 and 8 are linked. Please do all of them.
// IMPLEMENTING A+B IN Function1. THE Function1 MUST RETURN THE OUTPUT FOR FURTHER CALCULATION
// Function2 takes the output from Function 1 and print the squared result. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace functions_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            a = 1;
            b = 2;

            int Function1()
            {
                return a + b;
            }

            int c;
            c = Function1();
            Console.WriteLine("this is to test that the code above works");
            Console.WriteLine("Output of c is" + " " + c);

            void Function2(int takingvalue)
            {
                Console.WriteLine("Square is: " + takingvalue * takingvalue);           
            }

            Function2(c);

            Console.ReadKey();
        }
    }
}
