using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TA
    {
        protected static List<string> _instances;
        protected string name;

        protected string Name { get { return name; } }

        static TA()
        {
            _instances = new List<string>();
        }
        protected TA()
        {
            //Do nothing, this must be coming from a class that does not require it.
        }
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
