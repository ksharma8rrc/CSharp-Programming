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
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Hyundai", "Audi" };
            Console.WriteLine("The length of array is: " + cars.Length);
            int i = 0;
            while (i<cars.Length)
            {
                Console.Write("This is loop cycle: " + i + ": : " + cars[i]);
                i++; // or i = i+1;
                Console.Write("\nincremented value of i:  " + i);
                Console.Write("\n------------------------");
                Console.Write("\nHIT ENTER FOR ANOTHER CYCLE");
                Console.ReadKey();
            }
            Console.WriteLine("\nHIT ENTER TO EXIT PROGRAM \n");
            Console.ReadKey();
        }
    }
}
