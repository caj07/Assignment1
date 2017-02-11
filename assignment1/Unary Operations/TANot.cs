using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TANot : UnaryOperations
    {
        public TANot(string staticName) : base(staticName)
        {
        }
        public TANot(TABool val)
        {
            this.obj = val;
        }

        public new object State { get { return base.State; } }

        public override void Evaluate()
        {
            this.state = !((TABool)obj).State;
        }

        public override void PrintState()
        {
            Console.WriteLine(this.State);
        }
    }
}
