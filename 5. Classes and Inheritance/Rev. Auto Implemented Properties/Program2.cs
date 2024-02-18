using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{

    public class MyClass
    {
        // this is a field.  It is private to your class and stores the actual data.
        private string _myField;

        // this is a property. When accessed it uses the underlying field,
        // but only exposes the contract, which will not be affected by the underlying field
        public string MyProperty
        {
            get
            {
                return _myField;
            }
            set
            {
                _myField = value;
            }
        }

        // This is an AUTOPROPERTY (C# 3.0 and higher) - which is a shorthand syntax
        // used to generate a private field for you
        public int AnotherProperty { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.MyProperty = "COMING FROM MY PROPERY";
            Console.WriteLine(myClass.MyProperty);

            myClass.AnotherProperty = 20;
            Console.WriteLine("COMING FROM AUTO PROPERTY " + myClass.AnotherProperty);
            Console.ReadKey();            
        }
    }
}
