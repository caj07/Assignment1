using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAArray : Complex
    {
        private TA[] array;
        private int size;

        public TAArray(string staticName, Type type, int maxSize) : base(staticName)
        {
            if (type == typeof(TABool))
            {
                array = new TABool[maxSize];
            }
            else if (type == typeof(TAInt))
            {
                array = new TAInt[maxSize];
            }
            else if (type == typeof(TADouble))
            {
                array = new TADouble[maxSize];
            }
            else if (type == typeof(TAArray))
            {
                array = new TAArray[maxSize];
            }
            else if (type == typeof(TAPair))
            {
                array = new TAPair[maxSize];
            }
            else if (type == typeof(Primitives))
            {
                array = new Primitives[maxSize];
            }
            else if (type == typeof(Complex))
            {
                array = new Complex[maxSize];
            }
            else if (type == typeof(TA))
            {
                array = new TA[maxSize];
            }
            else
            {
                throw new Exception("The provided Type is not supported");
            }
            size = maxSize;
        }

        public TA Index(int index)
        {
            return array[index];
        }

        public int Size(int index)
        {
            return size;
        }
    }
}
