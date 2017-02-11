using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Complex : StaticName
    {
        protected object value;

        protected object Value { get { return value; } }

        protected Complex(string staticName) : base(staticName)
        {

        }

        public Complex() 
        {

        }
        protected void Set(object val)
        {
            value = val;
        }
    }
}
