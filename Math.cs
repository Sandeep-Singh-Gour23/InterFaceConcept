using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceConcept
{
    public class Math : IMath
    {
        public void add(int x, int y)
        {
           Console.WriteLine(x + y);
        }
        public void subtract(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public void multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void divide(double x, double y)
        {
            Console.WriteLine(x / y);
        }

    }

}
