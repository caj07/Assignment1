using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class TACeiling : UnaryOperations
    {
        public new object State { get { return base.State; } }
        protected TACeiling(TADouble val, string staticName) : base(staticName)
        {
            this.obj = val;
        }
        public TACeiling(TADouble val)
        {
            this.obj = val;
        }
        public override void Evaluate()
        {
            this.state = Math.Ceiling(((TADouble)obj).State);
        }
        public override void PrintState()
        {
            Console.WriteLine(this.State);
        }
    }
}
