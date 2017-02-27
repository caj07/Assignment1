using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAXor : TABool, Operations
    {
        // stores the state of the 2 objects we should evaluate
        protected object object1;
        protected object object2;
        public new object State { get { return base.State; } }

        public TAXor(TABool a, TABool b, string staticName) : base(staticName)
        {
            SetObjects(a, b);
        }
        public TAXor(TABool a, TABool b)
        {
            SetObjects(a, b);
        }
        //Sets the properties
        private void SetObjects(object a, object b)
        {
            this.object1 = a;
            this.object2 = b;
        }
        //Evaluates and update the current state of the object
        public void Evaluate()
        {
            if (object1 is Operations)
            {
                ((Operations)object1).Evaluate();
            }
            if (object2 is Operations)
            {
                ((Operations)object2).Evaluate();
            }
            this.Set(((TABool)object1).State ^ ((TABool)object2).State);
        }
        //Prints the current state
        public void PrintState()
        {
            Console.WriteLine(this.State);
        }
    }
}
