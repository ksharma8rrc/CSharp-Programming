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

            for (int i = cars.Length-1 ; i>=0 ; i--)
            {
                
                if (cars[i] == "Ford") 
                { 
                    Console.WriteLine("\n\nSkipped one Iteration, reached ford\n\n"); 
                    continue; 
                }
                // notice how loop breaks and moves to the next iteration BMW. Ford does not get printed
                Console.Write("This is loop cycle: " + i + ": : " + cars[i]);
                Console.Write("\nHIT ENTER FOR ANOTHER CYCLE");
                Console.ReadKey();
            }
            Console.WriteLine("\nHIT ENTER TO EXIT PROGRAM \n");
            Console.ReadKey();
        }
    }
}
