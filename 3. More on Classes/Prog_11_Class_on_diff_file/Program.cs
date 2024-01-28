using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RRC.ADEV.cssharp;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // memorize to create object
            Adev obj1 = new Adev();
            obj1.GetData(50, "ADEV-2008");
            obj1.PrintData();

            Adev obj2 = new Adev();
            obj2.GetData(318, "Princess St.");
            obj2.PrintData();

            Console.ReadKey();

        }
    }
}
