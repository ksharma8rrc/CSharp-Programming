// We see how to use enumeration withing a single file
// You may read some theory after following this example https://adev-2008-course-notes.pages.dev/csharp-fundamentals/enumerations/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{

    public enum CardRank
    {
        // I have default values starting from 0. Hover your mouse over Ace, two ,four and see.

        // BEAWARE!!!! WITH ENUMS YOU CAN ASSIGN THE SAME CUSTOM INTEGER VALUE TO MORE THAN TWO MEMBERS 
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    internal class Program
    {
 

        public static void Main(string[] args)
        {
            // Let's start priting. You would need to memorize this format for access the values in a enum
            // The enum here is CardRank

            // the statement below prints just the string part but enum also has index attached to it.
            Console.WriteLine(CardRank.Ace);

            // Lets print the index of King
            // Notice how we have to specify that we want to pull the integal index of the enum element king.
            Console.WriteLine((int)CardRank.King);

            // Lets try to grab the string part by using the index itself
            Console.WriteLine((CardRank)10);

            Console.ReadKey();

        }
        
    }
}




