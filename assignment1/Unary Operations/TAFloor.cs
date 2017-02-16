using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAFloor : UnaryOperations
    {
        //Returns the state of instance
        public new object State { get { return base.State; } }
        //Constructor that calls the base constructor with the instance static name
        public TAFloor(TADouble val, string staticName) : base(staticName)
        {
            this.obj = val;
        }
        // Static name is optional, so this constructor is for the other case
        public TAFloor(TADouble val)
        {
            this.obj = val;
        }
        //Evaluates and update the current state to the floor of the object
        public override void Evaluate()
        {
            this.state = Math.Floor(((TADouble)obj).State);
        }
        //Prints the current state
        public override void PrintState()
        {
            Console.WriteLine(this.State);
        }
    }
}
