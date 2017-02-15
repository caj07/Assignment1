using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAConstant : TA
    {
        private readonly int constant;
        public TAConstant(int constant, string staticName) : base(staticName)
        {
            this.constant = constant;
        }
        public TAConstant(int constant) : base()
        {
            this.constant = constant;
        }
        public int State { get { return constant; } }
        
    }
}
