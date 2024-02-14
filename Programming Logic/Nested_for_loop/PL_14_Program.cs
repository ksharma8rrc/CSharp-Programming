
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
            
            string[] days = { "Monday", "Tuesday", "Wednesday"};
            string[] mood = { "Morning Happy", "Afternoon Sad", " Evening Angry" };

            for (int m = 0; m<days.Length; m ++)
            {
                for (int n = 0; n < mood.Length; n ++) 
                {
                    Console.WriteLine(days[m] + " " + mood[n]);
                    Console.ReadKey();
                }
                
                Console.Write("InnerLoop Ended");
                Console.ReadKey();
                Console.WriteLine("--------------------------------");
            }
            Console.ReadKey();
        }
    }
}
