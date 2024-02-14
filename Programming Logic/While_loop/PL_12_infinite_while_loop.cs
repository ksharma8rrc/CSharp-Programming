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
          int tracker = 0;
            while (true)
            {
                Console.WriteLine("this is infinite while loop cycle: " + tracker );
                tracker++;
            }
            
            Console.ReadKey();
        }
    }
}
