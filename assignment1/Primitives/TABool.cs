using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TABool : Primitives
    {
        public TABool(string staticName) : base(staticName)
        {
        }
        public new bool State { get { return (bool)base.State; } }

        public void Set(bool val)
        {
            base.Set(val);
        }
    }
}
