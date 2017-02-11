﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAEqual : Operations
    {
        public new object State { get { return base.State; } }

        public TAEqual(TAInt a, TAInt b, string staticName) : base(staticName)
        {
            SetObjects(a, b);
        }
        public TAEqual(TADouble a, TADouble b, string staticName) : base(staticName)
        {
            SetObjects(a, b);
        }
        public TAEqual(TABool a, TABool b, string staticName) : base(staticName)
        {
            SetObjects(a, b);
        }
        public TAEqual(TAInt a, TAInt b)
        {
            SetObjects(a, b);
        }
        public TAEqual(TABool a, TABool b)
        {
            SetObjects(a, b);
        }
        public TAEqual(TADouble a, TADouble b)
        {
            SetObjects(a, b);
        }

        private void SetObjects(object a, object b)
        {
            this.object1 = a;
            this.object2 = b;
        }
        public override void Evaluate()
        {
            if (object1 is TAInt)
            {
                this.state = ((TAInt)object1).State == ((TAInt)object2).State;
            }
            else if (object1 is TADouble)
            {
                this.state = ((TADouble)object1).State == ((TADouble)object2).State;
            }
            else if (object1 is TABool)
            {
                this.state = ((TABool)object1).State == ((TABool)object2).State;
            }
        }
        public override void PrintState()
        {
            Console.WriteLine(this.State);
        }
    }
}
