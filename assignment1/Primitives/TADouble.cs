using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TADouble : Primitives
    {
        // Constructor, calls the base constructor which is Primitives
        public TADouble(string staticName) : base(staticName)
        {
        }

        // Return the state of the instance
        public new double State { get { return (double)base.State; } }        

        // Set the value of the state
        public void Set(double val)
        {
            base.Set(val);
        }
    }
}
