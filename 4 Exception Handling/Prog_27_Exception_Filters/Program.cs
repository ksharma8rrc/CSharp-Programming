using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You can use multiple catch blocks with the different exception type parameters. This is called exception filters. 
 Exception filters are useful when you want to handle different types of exceptions in different ways. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a number to divide 100: ");
        
        try
        {
            int num = int.Parse(Console.ReadLine());

            int result = 100 / num;

            Console.WriteLine("100 / {0} = {1}", num, result);
        }
        catch(DivideByZeroException ex)
        {
            Console.Write("Cannot divide by zero. Please try again.");
        }
        catch(InvalidOperationException ex)
        {
            Console.Write("Invalid operation. Please try again.");
        }
        catch(FormatException  ex)
        {
            Console.Write("Not a valid format. Please try again.");
        }
        catch(Exception  ex)
        {
            Console.Write("Error occurred! Please try again.");
        }
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

}
