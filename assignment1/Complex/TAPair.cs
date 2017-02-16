using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAPair : Complex
    {
        // Property that holds 
        private TA[] objects = new TA[2];

        //Constructor that set the 2 pairs and sets the static name
        public TAPair(TA a, TA b, string staticName) : base(staticName)
        {
            SetObjects(a, b);
        }
        //Constructor that set the 2 pairs without the static name
        public TAPair(TA a, TA b) : base()
        {
            SetObjects(a, b);
        }
        // Return the first object of the pair
        public TA First()
        {
            return objects[0];
        }
        // Returns the index of the next item in the pair
        public TA Next()
        {
            index++;
            index = index % 2;
            return objects[index];
        }
        // Set the objects of the pair
        private void SetObjects(TA a, TA b)
        {
            objects[0] = a;
            objects[1] = b;
        }
    }
}
