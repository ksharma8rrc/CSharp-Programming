// Adding two numbers and printing the output. 
// To run this file. Copy and paste the entire thing into your Program.cs file, 
// Build > Clean Solution > Build and then click on start


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 1;
            // or you can directly define the value like below
            int b = 2;

            int c;
            c = a * b;

            // directly multiplying and storing value in c
            // uncomment the line below
            // int c = a * b;

            Console.WriteLine(c); 
            Console.ReadKey();
        }
    }
}

