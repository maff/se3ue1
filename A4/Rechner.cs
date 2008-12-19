using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A4
{
    class Rechner
    {
        private int _zahl1;
        private int _zahl2;
        private int _result;

        public int zahl1
        {
            get { return this._zahl1; }
            set { this._zahl1 = value; }
        }

        public int zahl2
        {
            get { return this._zahl2; }
            set { this._zahl2 = value; }
        }

        public int result
        {
            get { return this._result; }
            set { }
        }

        public void add()
        {
            this._result = this._zahl1 + this._zahl2;
        }

        public void subtract()
        {
            this._result = this._zahl1 - this._zahl2;
        }

        public void multiply()
        {
            this._result = this._zahl1 * this._zahl2;
        }

        public void divide()
        {
            double result;

            if(this._zahl2 != 0)
                result = this._zahl1 / this._zahl2;
            else
                result = 0;

            this._result = (int)result;
        }

        public void modulo()
        {
            this._result = this._zahl1 % this._zahl2;
        }
    }
}
