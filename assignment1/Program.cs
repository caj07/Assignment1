using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 2
            TAInt x = new TAInt("x");
            TADouble d = new TADouble("d");
            TACeiling y = new TACeiling(d); // denotes y is the ceiling of d
            TABool b = new TABool("b");
            TALessThan t1 = new TALessThan(x, y); // denotes x < y
            TAAnd t2 = new TAAnd(b, t1); // denotes b and t1
            //t2.List();// should print: (& b (< x (ceiling d ) ) )
            x.Set(5);
            d.Set(2.3);
            b.Set(true);

            t1.Evaluate();
            t1.PrintState();// should print: false
            d.Set(5.3);
            t1.Evaluate();
            t1.PrintState();// should print: true

            //Problem 3
            TAConstant N = new TAConstant(16); // surprise
            TAConstant one = new TAConstant(1);
            TAInt x1 = new TAInt("x1");
            TADouble d1 = new TADouble("d1");
            TAPair p= new TAPair(x, d);
            //The following line is tricky:
            // what type should the second argument be declared as?
            TAArray a = new TAArray ("a", x.GetType(), N); //instantiate an array of integer with capacity 16
            TAInt i = new TAInt("i");
            TAPlus exp = new TAPlus(i, one);
            TAArrayAccess ai = new TAArrayAccess(a, one);
            TAPair p2 = new TAPair(ai, x);
            i.Set(1);
            ai.Set(7); // The type of the argument of set for array access is also tricky


            Console.ReadLine();
        }
    }
}
