using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RRC.Kushagra.Sharma;

namespace Classes_rev
{
    internal class Program
    {

        static void Main(string[] args)
        {

            List<Testing> object_list = new List<Testing>();
            object_list.Add(new Testing(1, "Hello World"));

            object_list[0].printing();

            object_list.Add(new Testing(10, "Solar System"));
            object_list[1].printing();

            Console.WriteLine("Total number of objects stored in the list is: " + object_list.Count);
            Console.WriteLine("The type of this list is: " + object_list);

            Console.ReadKey();

        }
    }
}
