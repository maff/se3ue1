using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A2
{
    class Wert
    {
        public Wert(int value)
        {
            Console.WriteLine("Die Ganzzahl lautet: {0}", value);
        }

        public Wert(double value)
        {
            Console.WriteLine("Die Dezimalzahl lautet: {0}", value);
        }

        public Wert(string value)
        {
            Console.WriteLine("Der Text lautet: {0}", value);
        }
    }
}
