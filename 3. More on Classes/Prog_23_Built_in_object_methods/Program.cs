// Built in methods that every object get. Read more on https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-8.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Pizza
    {
        string x; string y; string z;
        public Pizza(string x)
        {
            this.x = x;
            Console.WriteLine("The pizza you odered is: " +  x);
        }
        public Pizza(string x, string y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("The pizza you odered is: " + x + ", " + y);

        }

        public Pizza(string x, string y, string z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            Console.WriteLine("The pizza you odered is: " + x + ", " + y + ", " +z);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza obj1 = new Pizza("Pepperoni", "No Cheese");
            Pizza obj2 = new Pizza("Pepperoni");
            bool v = ReferenceEquals(obj1, obj2);
            Console.WriteLine("These objects are Equal True/False: " + v);
            Console.WriteLine(obj1.ToString());
            Console.ReadKey(); 
        }
    }
}
