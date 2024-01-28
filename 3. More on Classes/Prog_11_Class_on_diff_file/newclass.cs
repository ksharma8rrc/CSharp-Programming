
using System;

namespace RRC.ADEV.cssharp
{

    public class Adev
    {
        // step 1 Declare 
        int a;
        string b;

        // step 2 Get the information 

        public void GetData(int xx, string yy)
        {
            this.a = xx;
            this.b = yy;
        }

        // step 3: do stuff
        public void PrintData()
        {
            Console.WriteLine(" This is teh int I got: " + a);
            Console.WriteLine(" This is the STRING I got: " + b);
        }

    }

}
