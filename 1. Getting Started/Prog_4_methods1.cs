// Please read the Readme.md file in main git repo to use this document better.
// We see how to use enumeration withing a single file.
// You may read some theory after following this example https://adev-2008-course-notes.pages.dev/csharp-fundamentals/methods/
// functions are used to control the execution of a piece of code. If function is not called, it won't be executed.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{


    internal class Program
    {
 

        public static void Main(string[] args)
        {

            int a = 5; int b = 10;

            // void means that the function is not returning anything. We will see what "return" means later.
            // here I have declared a variable c and then printed the variable c
            void addition() 
            { 
                int c = a + b;
                Console.WriteLine("This is from the fun addition:"+" "+ c);
            }

            // Note: you can write some can do some algerbra within the print statement itself too. Look below
            void multiply()
            {
                Console.WriteLine("This is from the fun addition:" + " " + a * b);
            }

            // calling the function - you must comment out one or both the statements below to see what happens.
            addition();
            multiply();


            Console.ReadKey();

        }
        
    }
}
