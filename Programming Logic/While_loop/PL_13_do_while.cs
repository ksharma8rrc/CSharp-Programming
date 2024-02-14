//The do while loop is the same as while loop except that it executes the code block at least once.
/*
The do-while loop starts with the do keyword followed by a code block and a boolean expression with the while keyword. 
The do while loop stops execution exits when a boolean condition evaluates to false. 
Because the while(condition) specified at the end of the block, it certainly executes the code block at least once.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("i = {0}", i);
                i++;

                if (i > 5)
                    break;

            } while (i < 10);
            Console.ReadKey();
        }
    }
}
