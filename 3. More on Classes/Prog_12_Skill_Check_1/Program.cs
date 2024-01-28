using RRC.ADEV.csharp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentInfo obj1 = new StudentInfo();

            // passing values and setting info in the obj-class
            obj1.GetInfo(6767, "Kushagra", "Sharma");

            Console.WriteLine("The student ID is: " + obj1.GetID());
            Console.ReadKey();
            Console.WriteLine("The student's First Name is: " + obj1.Return_Fname());
            Console.ReadKey();
            Console.WriteLine("The student's Last Name is: " + obj1.Return_Lname());
            Console.ReadKey();

            StudentInfo obj2 = new StudentInfo();
            obj2.GetInfo(67788, "Joe", "Doe");

            Console.WriteLine("The student ID is: " + obj2.GetID());
            Console.ReadKey();
            Console.WriteLine("The student's First Name is: " + obj2.Return_Fname());
            Console.ReadKey();
            Console.WriteLine("The student's Last Name is: " + obj2.Return_Lname());
            Console.ReadKey();

        }
    }
}

