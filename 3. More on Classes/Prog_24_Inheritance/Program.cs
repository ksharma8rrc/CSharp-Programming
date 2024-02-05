
// Built in methods that every object get. Read more on https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-8.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //Keeping Collision Records
    class Collision 
    {
        public void Print(string x, int y)
        {
            Console.WriteLine("Survival chance in a " + x + " collision is " + y + "%");
        }

    }
    
    class Car: Collision {
       
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car obj1 = new Car();
            obj1.Print("car", 10);
            Console.ReadKey(); 
        }
    }
}
