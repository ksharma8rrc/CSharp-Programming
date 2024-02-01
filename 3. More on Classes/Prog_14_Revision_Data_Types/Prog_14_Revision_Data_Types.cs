using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // full specification available on https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/types


            int a = 56;                   // integer (whole number)
            long b = 432544323423443534;
            float c = 55646755675675673453453453453455345345.75F; // 32-bit
            double d = 55646755675675673453453453453455345345456456456456.999D;  // 64-bit floating point number.
                                                                                 // BUT can hold a larger number as it uses exponets for representing
            decimal e = 5564675567999545645645456456.6M; // 128-bit // better precision than double

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);



            char myLetter = 'D';         // character
            bool myBool = true;          // boolean
            string myText = "Hello";     // string
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);


            Console.ReadKey();
        }
    }
}
