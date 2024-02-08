using System;

public class ThrowTest
{
    public static void fn(string name)
    {
        if (name.Trim().Equals(string.Empty))
        {
        
            throw new ArgumentException("Need atleast one character");
        }
        else 
       {
            Console.WriteLine("ALL GOOD HERE. No Worries");
        }
    }

    public static void Main()
    {
    
        try
        {
            fn("  f  ");

        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            
        }
      
        Console.ReadKey();
    }
}
