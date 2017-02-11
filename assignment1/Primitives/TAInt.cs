using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAInt : Primitives
    {
        public TAInt(string staticName) : base(staticName)
        {
        }
        public new int State { get { return (int)base.State; } }

        public void Set(int val)
        {
            base.Set(val);
        }
    }
}
