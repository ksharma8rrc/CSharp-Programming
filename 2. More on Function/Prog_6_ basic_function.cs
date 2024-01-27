// Prog_6 and Prog_7 are linked. Please do both of them
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
            int c;
            a = 1;
            b = 2;

            //function to add a and return the result. Since it is returning and interger, we have return type "int" in front of the name "function1"
            int Function1()
            {
                return a + b;
            }
          
            // call a function and storing the returned int output in c
            c = Function1();

            // simple print statements. These statements could be inside the function as well but we chose not to for clarity.
          
            Console.WriteLine("this is to test that the code above works");
            Console.WriteLine("Output of c is" + " " + c);
            Console.ReadKey();
        }
    }
}

