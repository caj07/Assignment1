using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAConstant : TA
    {
        // private property of the constant
        private int constant;
        //Constructor that initializes the class and provides it with a name and the constant value.
        public TAConstant(int constant, string staticName) : base(staticName)
        {
            this.constant = constant;
        }

        //Constructor that initializes the class and provides it with the constant value.
        public TAConstant(int constant) : base()
        {
            this.constant = constant;
        }
        // State property return the constant value
        public int State { get { return constant; } }
        
    }
}
