// Please read the Readme.md file in main git repo to use this document better.
// We see how to use enumeration withing a single file.
// You may read some theory after following this example https://adev-2008-course-notes.pages.dev/csharp-fundamentals/methods/
// You may read some theory after following this example https://adev-2008-course-notes.pages.dev/csharp-fundamentals/classes/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{


    internal class Program
    {

        public class Adev
        {
            int a = 5; int b = 10;

            // in the example Prog_4, we started a the function directly with void because it was within the main itself.
            // Any function is accessable to the functions or data only within the class. 
            // If you would remove public and try access the function from main, it is gonna throw you an error. 
            // Must test yourself 
            public void addition()
            {
                int c = a + b;
                Console.WriteLine("This is from the fun addition:" + " " + c);
            }

            public void multiply()
            {
                Console.WriteLine("This is from the fun addition:" + " " + a * b);
            }

        }

        public static void Main(string[] args)
        {

        // To use classes, you need to create an object first.
        // The way object is create is very unapplealing so you must memorize it. 
        // we have created an object - obj1 of class Adev

             Adev obj1 = new Adev();


            // calling the function - since this function is within a different class, you must call it using it's object
            // NOTE: you cannot call a class directly. 

            obj1.addition();
            obj1.multiply();

            Console.ReadKey();

        }
        
    }
}
