using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TADouble : Primitives
    {
        public TADouble(string staticName) : base(staticName)
        {
        }

        public new double State { get { return (double)base.State; } }        

        public void Set(double val)
        {
            base.Set(val);
        }
    }
}
