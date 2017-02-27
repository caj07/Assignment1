using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAConstant : TAInt
    {
        //Constructor that initializes the class and provides it with a name and the constant value.
        public TAConstant(int constant, string staticName) : base(staticName)
        {
            this.Set(constant);
        }

        //Constructor that initializes the class and provides it with the constant value.
        public TAConstant(int constant) : base()
        {
            this.Set(constant);
        }
        
    }
}
