using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAMinus : Primitives, Operations
    {
        // Stores the object that we will evaluate or print its state
        protected object obj;
        //Returns the state of instance
        public new object State { get { return base.State; } }
        //Constructor that calls the base constructor with the instance static name
        public TAMinus(Primitives val,string staticName) : base(staticName)
        {
            this.obj = val;
        }
        // Static name is optional, so this constructor is for the Primitves without a name
        public TAMinus(Primitives val)
        {
            this.obj = val;
        }

        //Evaluates and update the current state
        public void Evaluate()
        {
            if (obj is TADouble)
            {
                this.Set(-((TADouble)obj).State);
            }
            else if (obj is TAInt)
            {
                this.Set(-((TAInt)obj).State);
            }
        }

        //Prints the current state
        public void PrintState()
        {
            Console.WriteLine(this.State);
        }
    }
}
