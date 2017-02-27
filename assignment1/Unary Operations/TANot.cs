using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TANot : TABool, Operations
    {
        // Stores the object that we will evaluate or print its state
        protected object obj;

        //Constructor that calls the base constructor with the instance static name
        public TANot(TABool val,string staticName) : base(staticName)
        {
            this.obj = val;
        }
        // Static name is optional, so this constructor is for the other case
        public TANot(TABool val)
        {
            this.obj = val;
        }
        //Returns the state of instance
        public new object State { get { return base.State; } }
        
        //Evaluates and update the current state
        public void Evaluate()
        {
            this.Set(!((TABool)obj).State);
        }

        //Prints the current state
        public void PrintState()
        {
            Console.WriteLine(this.State);
        }
    }
}
