using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAInt : Primitives
    {
        // Constructor, calls the base constructor which is Primitives
        public TAInt(string staticName) : base(staticName)
        {
        }
        // Return the state of the instance
        public new int State { get { return (int)base.State; } }

        // Set the value of the state
        public void Set(int val)
        {
            base.Set(val);
        }
    }
}
