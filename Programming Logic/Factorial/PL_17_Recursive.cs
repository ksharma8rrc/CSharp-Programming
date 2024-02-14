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

            int tracker = 1;

            int factorial_recursive(int xx)
            {
                Console.WriteLine("This is iteration: " + tracker);
                tracker++;
                if (xx == 0 || xx == 1)
                    return 1;
                return xx * factorial_recursive((int) xx - 1);
            }
        
            Console.WriteLine("The The Factorial is: " + factorial_recursive(x));
            Console.ReadKey();
        }
    }
}
