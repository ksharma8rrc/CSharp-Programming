// this code works. Good for learning how classes work but not the best way to code.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_rev
{
    internal class Program
    {
        class Testing
        {
            int x;

            public void Getint(int xx)
            {
                this.x = xx;
                Console.WriteLine(x);
            }
        }

        static void Main(string[] args)
        {

            Testing obj1 = new Testing();
            obj1.Getint(5);

            Testing obj2 = new Testing();
            obj2.Getint(50);
            
            Console.ReadKey();

        }
    }
}
