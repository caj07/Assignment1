using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TAArray : Complex
    {
        // array property
        private TA[] array;
        // holds the size of the array
        private int size;

        // Constructor of the array. Checks which type the array should be. Also includes the static name and size of the array.
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

        // Returns the value in the array at the specific index
        public TA Index(int index)
        {
            return array[index];
        }

        // Returns the size of the array.
        public int Size(int index)
        {
            return size;
        }
    }
}
