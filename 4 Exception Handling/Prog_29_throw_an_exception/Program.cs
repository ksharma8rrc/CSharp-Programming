using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ThrowTest
{
    public void fn(int age)
    {
        if (age < 18)
        {
            throw new Exception("You are not old enough for this application");
        }
        else 
        {
            Console.WriteLine("ALL GOOD, you can sign up");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        ThrowTest obj1 = new ThrowTest();

        try
        {
            obj1.fn(15);
        }
        catch (Exception e) 
        {
           Console.WriteLine("Error in e: " + (e.Message));
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

}
