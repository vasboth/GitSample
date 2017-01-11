using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    interface ICalc
    {
        double Add(double x, double y);
        
        int Div(int x, int y);

        double DivD(double x, double y);

        double Mult(double x, double y);
    }
}
