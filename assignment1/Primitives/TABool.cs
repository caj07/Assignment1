using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TABool : Primitives
    {
        // Constructor, calls the base constructor which is Primitives
        public TABool(string staticName) : base(staticName)
        {
        }
        protected TABool() :base()
        {

        }
        // Return the state of the instance
        public new bool State { get { return (bool)base.State; } }

        // Set the value of the state
        public void Set(bool val)
        {
            base.Set(val);
        }
    }
}
