using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAArraySize : TAInt
    {
        public TAArraySize(TAArray array, string staticName) : base(staticName)
        {
            this.Set(array.Size);
        }

        //Constructor that initializes the class and provides it with the constant value.
        public TAArraySize(TAArray array) : base()
        {
            this.Set(array.Size);
        }
    }
}
