using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{

    public class Random1
    {
        public int a { get; set; }
        
        public Random1(int aa)
        {
            this.a = aa;
        }

        public int squared()
        {
            return a*a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
