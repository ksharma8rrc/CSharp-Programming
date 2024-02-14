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
            Console.WriteLine("Creating a 2D matrix");

            for (int m = 0; m<4; m ++)
            {
                for (int n = 0; n < 3; n ++) 
                {
                    Console.WriteLine(m + " " + n);
                    Console.ReadKey();
                }
    
                Console.Write("InnerLoop Ended");
                Console.ReadKey();
                Console.WriteLine("--------------------------------");
            }
            Console.ReadKey();
        }
    }
}
