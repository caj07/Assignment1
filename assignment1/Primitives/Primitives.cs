using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public abstract class Primitives : StaticName 
    {       
        private object state;

        public virtual object State { get { return state; } }       

        protected Primitives(string staticName) : base(staticName)
        {
           
        }
        protected void Set(object val)
        {
            state = val;
        }
    }
}
