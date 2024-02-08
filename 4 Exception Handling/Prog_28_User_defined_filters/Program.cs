using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You can use multiple catch blocks with the different exception type parameters. This is called exception filters. 
 Exception filters are useful when you want to handle different types of exceptions in different ways. 
Here: when is used to skim through the error message and execute the catch block only when that specific keyword is found.
*/

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
        catch(Exception  ex) when (ex.Message.Contains("zero")) 
        {
            Console.Write("Error occurred! Please try again.\n" + ex.Message);
        }
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

}
