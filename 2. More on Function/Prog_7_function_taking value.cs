// Prog_6,  Prog_7, Prog_8 are linked. Please do all of them.
// This program shows how you can pass values or arguments to a function.
// Objective: function2 must take the integer argument. It must print the squared result. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fun_taking_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            // This function takes the integer a with value 5 and prints the squared result.
            void function2(int takingvalue)
            {
                Console.WriteLine("Square is: " + takingvalue * takingvalue);
                Console.ReadKey();
            }

            //passing int a, which as value 5 to the function
            function2(a);

        }
    }
}
