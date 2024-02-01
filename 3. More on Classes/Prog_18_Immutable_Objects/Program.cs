using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RRC.Kushagra.Sharma;
using System.Collections.Immutable;

namespace Classes_rev
{
    internal class Program
    {

        static void Main(string[] args)
        {

            ImmutableList<Testing> object_list = ImmutableList.Create<Testing>();

            object_list = object_list.Add(new Testing(1, "Hello World"));

            object_list[0].printing();

            object_list= object_list.Add(new Testing(10, "Solar System"));
            object_list[1].printing();

            //UNCOMMENT THE LINE BELOW TO SEE WHAT HAPPENS
            //object_list[1] = new Testing(10, "MARS");
            //object_list[1].printing();

            Console.ReadKey();

        }
    }
}
