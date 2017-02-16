using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    //Class present to be able to group all classes that are complex
    public class Complex : TA
    {
        //Property shared between all sub classes
        protected int index;

        //Constructor for instantiation with a static name
        protected Complex(string staticName) : base(staticName)
        {

        }
        //Constructor present for class that do not require name instantiation (i.e. Pair)
        public Complex() 
        {

        }
    }
}
