using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAMinus : UnaryOperations
    {
        public new object State { get { return base.State; } }
        public TAMinus(TADouble val,string staticName) : base(staticName)
        {
            this.obj = val;
        }
        public TAMinus(TADouble val)
        {
            this.obj = val;
        }
        public TAMinus(TAInt val)
        {
            this.obj = val;
        }

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

        public override void PrintState()
        {
            Console.WriteLine(this.State);
        }
    }
}
