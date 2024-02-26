//Use the static modifier to declare a static member, which belongs to the type itself rather than to a specific object. The static modifier can be used to declare static classes.

using System;

namespace MyFirstProgram
    {
        public class Car
        {
            String model;
            public static int numberOfCars;

            public Car(String model)
            {
                this.model = model;
                numberOfCars++;
            }

            public static void StartRace()
            {
                Console.WriteLine("The race has begun!");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // static = modifier to declare a static member, which belongs to the class itself
                //          rather than to any specific object

                Car car1 = new Car("Mustang");
                Car car2 = new Car("Corvette");
                Car car3 = new Car("Lambo");

                Console.WriteLine(Car.numberOfCars);
                Car.StartRace();

                Console.ReadKey();
            }
        }
}
