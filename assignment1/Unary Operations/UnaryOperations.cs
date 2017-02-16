using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public abstract class UnaryOperations : TA
    {
        // Stores the object that we will evaluate or print its state
        protected object obj;
        // Stores the state of the object
        protected object state;

        // Returns the state of the object
        protected object State { get { return state; } }

        // Constructor for unary operations when they insert a static name
        protected UnaryOperations(string staticName) : base(staticName)
        {
        }
        // Constructor for unary operations when they do not insert a static name
        protected UnaryOperations():base()
        {
        }
        //Forces the sub classes to implement an evaluate function
        public abstract void Evaluate();
        //Forces the sub classes to implement an print state function
        public abstract void PrintState();
    }
}
