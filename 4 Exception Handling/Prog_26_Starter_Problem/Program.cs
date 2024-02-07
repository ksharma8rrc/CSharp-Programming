using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int[] myNumbers = { 1, 2, 3, 4, 5 };
                Console.WriteLine(myNumbers[6]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

        }
    }
}
