using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public interface Operations
    {        
        //Forces the sub classes to implement an evaluate function
        void Evaluate();
        //Forces the sub classes to implement an print state function
        void PrintState();
    }
}
