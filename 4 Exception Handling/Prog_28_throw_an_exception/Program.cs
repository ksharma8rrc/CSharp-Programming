using System;

public class ThrowTest
{
    public static void fn(Int32 age)
    {
        if (age < 0)
        {
            // throw an argument out of range exception if the age is
            // less than zero.
            throw new ArgumentOutOfRangeException("Age Cannot Be Negative ");
        }
    }

    public static void Main()
    {
    
        try
        {
            fn(-10);
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            
        }
      
        Console.ReadKey();
    }
}
