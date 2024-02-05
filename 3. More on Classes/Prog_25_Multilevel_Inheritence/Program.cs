using System;

namespace Sample.Code
{
    public class A
    {
        public string Name;
        public void GetName()
        {
            Console.WriteLine("Name: {0}", Name);
        }
    }
    public class B : A
    {
        public string Location;
        public void GetLocation()
        {
            Console.WriteLine("Location: {0}", Location);
        }
    }
    public class C : B
    {
        public int Age;
        public void GetAge()
        {
            Console.WriteLine("Age: {0}", Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c_obj = new C();
            c_obj.Name = "Joe Doe";
            c_obj.Location = "Winnipeg";
            c_obj.Age = 27;
            c_obj.GetName();
            c_obj.GetLocation();
            c_obj.GetAge();
            Console.WriteLine("\nPress Any Key to Exit..");
            Console.ReadKey();
        }
    }
}
