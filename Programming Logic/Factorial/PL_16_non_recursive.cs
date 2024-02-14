

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Computing Factorial using for loop i.e. Non-recursive");
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int multiply = 1;

            for (int i = 1; i <= x; i++) 
            {
                multiply = multiply* i;
                Console.WriteLine(multiply);
            }
            Console.WriteLine("The The Factorial is: " + multiply);
            Console.ReadKey();
        }
    }
}
