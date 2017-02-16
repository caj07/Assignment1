using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public abstract class Primitives : TA 
    {       
        // Stores the state of the primitive
        private object state;

        // Returns the state of the class without permitting changes to it
        public virtual object State { get { return state; } }       

        // Constructor for instances that require
        protected Primitives(string staticName) : base(staticName)
        {
           
        }
        //used to set the state 
        protected void Set(object val)
        {
            state = val;
        }
    }
}
