using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAPair : Complex
    {
        private TA[] objects = new TA[2];

        public TAPair(TA a, TA b, string staticName) : base(staticName)
        {
            SetObjects(a, b);
        }
        public TAPair(TA a, TA b) : base()
        {
            SetObjects(a, b);
        }

        public TA First()
        {
            return objects[0];
        }
        public TA Next()
        {
            index++;
            index = index % 2;
            return objects[index];
        }
        private void SetObjects(TA a, TA b)
        {
            objects[0] = a;
            objects[1] = b;
        }
    }
}
