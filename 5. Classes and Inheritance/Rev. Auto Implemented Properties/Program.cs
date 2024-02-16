using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{

    public class Hey
    {
        //AUTO IMPLEMENTED
        // shorthand when no additional logic is required.
        // no need to define anything // just write get; and set;
        
        public int accountnumber {get; private set;} // use this when you don't wan't someone to maniplate the data
        //public int accountnumber { get; set; } // data could be manipulatied. set could be accessed publically
        public Hey(int ___accountnumber) { accountnumber = ___accountnumber;} // Constructor 

    }
    public class Heyhey
    {
        //NOT AUTO IMPLEMENTED

        private int sin_number;
        public int Data
        {
            get { return sin_number; }
            set { sin_number = value; } 
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //AUTO IMPLEMENTED
            Hey obj1 = new Hey(3);
            Console.WriteLine(obj1.accountnumber);

            //NOT AUTO IMPLEMENTED
            Heyhey obj2 = new Heyhey();
            obj2.Data = 1343;
            Console.WriteLine(obj2.Data);
            Console.ReadKey();

        }
    }
}
