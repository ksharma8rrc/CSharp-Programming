using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the value for x: ");
            string xx = Console.ReadLine();
            int x = Convert.ToInt32(xx);
            Console.WriteLine("Please enter the value for y: ");
            string yy = Console.ReadLine();
            int y = Convert.ToInt32(yy);
            // boolean can significatly change the execution of your code. 
            // look how we flipped everything by introducing true and false
            if (x > y == false)
            {
                Console.WriteLine("x is greater than y");
            }
            else if (y > x == true) 
            {
                Console.WriteLine("y is greater than x");
            }
            else 
            { 
                Console.WriteLine("Opps they must be equal"); 
            }
           
            Console.ReadKey();

        }
    }
}
