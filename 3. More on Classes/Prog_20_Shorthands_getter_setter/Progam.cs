// Using this method is not recommended. Please stick to the formal way of coding as they would work with every languagle. 
// WE MUST AVOID CODING SHORTHANDS AS THEY DON'T OFFER IMPLEMENTAION CLARITY 
// STICK TO PROG_19 METHOD


using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

    class Car
    {
        // declaration
        int speed;
        

        //constructor
        public Car(int sp) {
            //setting the speed
            this.speed = sp;
        }

        // getter ( to retrieve the info stored in declaration "speed"

        // notice we dont have "()" after function displaydetails // shorthand
        public int displaydetails
        {
           get { return this.speed; }
        }

        // notice we dont have "()" after function updatethevalue // shorthand
        public int updatethevalue
        {
            set { this.speed = value; }
        }

       
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //passing value to the constructor 
            Car car = new Car(100);
            Console.WriteLine(car.displaydetails);
            Console.ReadKey();
            //hit enter to display the next line


            //upadates the value 
            car.updatethevalue = 200;
            Console.WriteLine(car.displaydetails);
            Console.ReadKey();
        }
    }
}
