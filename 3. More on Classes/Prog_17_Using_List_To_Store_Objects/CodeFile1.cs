using System;

namespace RRC.Kushagra.Sharma
{
    class Testing
    {
        private int x;
        string y;

        public Testing(int xx, string yy) { 
        this.x = xx;
        this.y = yy;
        }


        public void printing()
        {
            Console.WriteLine("this is the integer " + x);
            Console.WriteLine("this is the string: " + y);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-------------------------------------------");
        }

    }

}
