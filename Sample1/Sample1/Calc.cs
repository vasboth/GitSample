using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    class Calc : ICalc
    {
        public double Add(double x, double y)
        {
            Console.WriteLine("Add");
            double result = x + y;
            return result;
        }

        public int Div(int x, int y)
        {
            int result = x / y;
            return result;
        }

        public double DivD(double x, double y)
        {
            double result = x / y;
            return result;
        }

        public double Mult(double x, double y)
        {
            double result = x * y;
            return result;
        }
    }
}
