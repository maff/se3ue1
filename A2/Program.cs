using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A2
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerValue = 15;
            double doubleValue = 13.76;
            string stringValue = "Lorem Ipsum";

            new Wert(integerValue);
            new Wert(doubleValue);
            new Wert(stringValue);

            Console.ReadLine();
        }
    }
}
