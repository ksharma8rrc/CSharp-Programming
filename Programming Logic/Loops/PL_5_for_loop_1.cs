using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("This is loop cycle: " +i);
                Console.Write("----------------------------");
                Console.Write("HIT ENTER FOR ANOTHER CYCLE");
                Console.ReadKey();
            }

            Console.WriteLine("\nHIT ENTER TO EXIT PROGRAM \n");
            Console.ReadKey();

        }
    }
}
