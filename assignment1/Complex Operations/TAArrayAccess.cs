using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAArrayAccess : TA
    {
        private TA arrayObject;
        public TAArrayAccess(TAArray array, TAInt index)
        {
            if (index is Operations)
            {
                ((Operations)index).Evaluate();
            }
            arrayObject = array.Index(index.State);
        }

        public void Set(int a)
        {
            if (!(arrayObject is Primitives))
            {
                throw new Exception("Wrong Invocation of Method. The object is not a Primitive type for it to be set");
            }
            if (arrayObject is TAInt)
            {
                ((TAInt)arrayObject).Set(a);
            }
            else
            {
                throw new Exception("Wrong Invocation of Method. The parameter type does not match with the array object");
            }
        }
        public void Set(double a)
        {
            if (!(arrayObject is Primitives))
            {
                throw new Exception("Wrong Invocation of Method. The object is not a Primitive type for it to be set");
            }
            if (arrayObject is TADouble)
            {
                ((TADouble)arrayObject).Set(a);
            }
            else
            {
                throw new Exception("Wrong Invocation of Method. The parameter type does not match with the array object");
            }
        }
        public void Set(bool a)
        {
            if (!(arrayObject is Primitives))
            {
                throw new Exception("Wrong Invocation of Method. The object is not a Primitive type for it to be set");
            }
            if (arrayObject is TABool)
            {
                ((TABool)arrayObject).Set(a);
            }
            else
            {
                throw new Exception("Wrong Invocation of Method. The parameter type does not match with the array object");
            }
        }
        public TA State { get { return arrayObject; } }

    }
}
