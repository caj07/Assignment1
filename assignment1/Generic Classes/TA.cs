using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TA
    {
        // Static list that contains all the names of created instances
        private static List<string> _instances;
        // The name of this specific instance
        private string name;

        // The property accessor of the name property. Allows only Read Access to the property
        protected string Name { get { return name; } }

        // static constructor that runs at the begininng and initializes the list of names
        static TA()
        {
            _instances = new List<string>();
        }
        // Constructor that is run on creation of the instance. Only present for classes that do not require initializing with a name property
        protected TA()
        {
            //Do nothing, this must be coming from a class that does not require it.
        }

        // Constructor that is run on creation of the instance. Checks if the name is already present: throws an eception if it is, adds it otherwise 
        protected TA(string staticName)
        {
            if (!string.IsNullOrEmpty(staticName))
            {
                if (_instances.Contains(staticName))
                {
                    throw new Exception("The provided instance name: " + staticName + ", already exists");
                }
                name = staticName;
            }
            else
            {
                throw new Exception("The provided instance name is empty or null");
            }
        }
    }
}
