// Using this method is HIGHLY recommended. Please stick to the formal way of coding as they would work with every languagle. 
// WE MUST AVOID CODING SHORTHANDS as in Prog 20-21 AS THEY DON'T OFFER IMPLEMENTAION CLARITY 
// STICK TO PROG_19 METHOD
using System;
using System.Collections.Generic;
using System.Data;
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
        public Car(int sp) 
        { 
            this.speed = sp; 
        }

        public int RetreiveInfo() {
            return speed;
        }

        public void UpdateSpeed(int sp) {
            this.speed = sp;
        }     
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //passing value to the constructor 
            Car car = new Car(100);
            Console.WriteLine(car.RetreiveInfo());
            Console.ReadKey();
            car.UpdateSpeed(200);
            Console.WriteLine(car.RetreiveInfo());
            Console.ReadKey();
        }
    }
}
