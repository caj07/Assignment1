using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public abstract class Operations : TA
    {
        protected object state;
        protected object object1;
        protected object object2;
        protected object State { get { return state; } }

        protected Operations(string staticName) : base(staticName)
        {
        }
        protected Operations() : base()
        {
        }
        public abstract void Evaluate();
        public abstract void PrintState();
    }
}
