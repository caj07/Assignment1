using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TANot : UnaryOperations
    {
        //Constructor that calls the base constructor with the instance static name
        public TANot(string staticName) : base(staticName)
        {
        }
        // Static name is optional, so this constructor is for the other case
        public TANot(TABool val)
        {
            this.obj = val;
        }
        //Returns the state of instance
        public new object State { get { return base.State; } }
        
        //Evaluates and update the current state
        public override void Evaluate()
        {
            this.state = !((TABool)obj).State;
        }

        //Prints the current state
        public override void PrintState()
        {
            Console.WriteLine(this.State);
        }
    }
}
