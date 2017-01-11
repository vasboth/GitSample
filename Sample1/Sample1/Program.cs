using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            int sum = x + y;
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, sum );

            int diff = x - y;
            Console.WriteLine("Difference of {0} and {1} is {2}", x, y, diff);

            int prod = x * y;
            Console.WriteLine("Product of {0} and {1} is {2}", x, y, prod);

            Console.ReadLine();


        }
    }
}
