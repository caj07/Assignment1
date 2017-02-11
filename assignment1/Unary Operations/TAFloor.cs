using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAFloor : UnaryOperations
    {
        public new object State { get { return base.State; } }
        public TAFloor(TADouble val, string staticName) : base(staticName)
        {
            this.obj = val;
        }
        public TAFloor(TADouble val)
        {
            this.obj = val;
        }
        public override void Evaluate()
        {
            this.state = Math.Floor(((TADouble)obj).State);
        }
        public override void PrintState()
        {
            Console.WriteLine(this.State);
        }
    }
}
