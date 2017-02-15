using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public abstract class UnaryOperations : TA
    {
        protected object obj;
        protected object state;

        protected object State { get { return state; } }

        protected UnaryOperations(string staticName) : base(staticName)
        {
        }
        protected UnaryOperations():base()
        {
        }
        public abstract void Evaluate();
        public abstract void PrintState();
    }
}
