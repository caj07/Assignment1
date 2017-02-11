using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAOr : Operations
    {
        public new object State { get { return base.State; } }

        public TAOr(TABool a, TABool b, string staticName) : base(staticName)
        {
            SetObjects(a, b);
        }
        public TAOr(TABool a, TABool b)
        {
            SetObjects(a, b);
        }
        private void SetObjects(object a, object b)
        {
            this.object1 = a;
            this.object2 = b;
        }
        public override void Evaluate()
        {
            this.state = ((TABool)object1).State || ((TABool)object2).State;
        }
        public override void PrintState()
        {
            Console.WriteLine(this.State);
        }
    }
}
