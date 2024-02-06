// Please read the Readme.md file in main git repo to use this document better.
// We see how to use enumeration withing a single file.
// Focusing on a special use case where assigning same integer value to an enum memmber may be useful
// You may read some theory after following this example https://adev-2008-course-notes.pages.dev/csharp-fundamentals/enumerations/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{

    public enum SortBy
    {
        Ascending = 0,
        Descending = 1,
        Asc = 0,
        Desc = 1
    }

    internal class Program
    {
 

        public static void Main(string[] args)
        {

            // Look how the enum number 0 pulls Ascending both the time, although both Ascending and Asc has value 0
            // You must be extrememly careful with this.
            Console.WriteLine((SortBy).0);
            Console.WriteLine((SortBy).0);

            //pringing the enum value of both the elements
            Console.WriteLine((int)SortBy.Ascending);
            Console.WriteLine((int)SortBy.Asc);

            //hold the screen
            Console.ReadKey();

        }
        
    }
}
