using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAMinus : UnaryOperations
    {
        //Returns the state of instance
        public new object State { get { return base.State; } }
        //Constructor that calls the base constructor with the instance static name
        public TAMinus(TADouble val,string staticName) : base(staticName)
        {
            this.obj = val;
        }
        // Static name is optional, so this constructor is for the TADouble without a name
        public TAMinus(TADouble val)
        {
            this.obj = val;
        }
        // Static name is optional, so this constructor is for the TAInt without a name
        public TAMinus(TAInt val)
        {
            this.obj = val;
        }

        //Evaluates and update the current state
        public override void Evaluate()
        {
            if (obj is TADouble)
            {
                this.state = -((TADouble)obj).State;
            }
            else if (obj is TAInt)
            {
                this.state = -((TAInt)obj).State;
            }
        }

        //Prints the current state
        public override void PrintState()
        {
            Console.WriteLine(this.State);
        }
    }
}
