using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RRC.Kushagra.Sharma;

namespace Classes_rev
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Testing obj1 = new Testing(5, " Hello");
            Testing obj2 = new Testing(50, " Hello World");

            Console.WriteLine(" THIS IS FROM OBJ1: ");
            obj1.printing();

            Console.WriteLine(" -------------------------------------------------------------");
            Console.WriteLine(" -------------------------------------------------------------");
            Console.WriteLine(" THIS IS FROM OBJ2: ");
            obj2.printing();

            Console.WriteLine(" -------------------------------------------------------------");
            Console.WriteLine(" -------------------------------------------------------------");
            Console.WriteLine(" THIS IS FROM OVERWRITTEN OBJ2:");
            obj2 = new Testing(50000, " OVERWRITTEN");

            obj2.printing();


            Console.ReadKey();

        }
    }
}
